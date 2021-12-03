using Spaghetti_Coders.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spaghetti_Coders.Controls
{
    /// <summary>
    /// Interaction logic for OrderItem.xaml
    /// </summary>
    public partial class OrderItem : UserControl
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register( "Title", typeof( string ), typeof( OrderItem ), new PropertyMetadata( string.Empty ) );

        public string Title
        {
            get { return (string)GetValue( TitleProperty ); }
            set { SetValue( TitleProperty, value ); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register( "ImageSource", typeof( ImageSource ), typeof( OrderItem ), new PropertyMetadata( null ) );

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue( ImageSourceProperty ); }
            set { SetValue( ImageSourceProperty, value ); }
        }

        public float PricePerItem = 0;

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register( "Quantity", typeof( string ), typeof( OrderItem ), new PropertyMetadata( string.Empty ) );

        public int Quantity
        {
            get { return int.Parse((string)GetValue(QuantityProperty)); }
            set { SetValue( QuantityProperty, value.ToString() ); }
        }

        public static readonly DependencyProperty PriceTotalProperty =
            DependencyProperty.Register( "PriceTotal", typeof( string ), typeof( OrderItem ), new PropertyMetadata( string.Empty ) );

        public float PriceTotal
        {
            get { return float.Parse( ( (string)GetValue( PriceTotalProperty ) ).Replace( "$", "" ) ); }
            set { SetValue( PriceTotalProperty, $"${value:0.00}" ); }
        }

        public List<string> Modifications = new List<string>();

        public delegate void UpdateDelegate();

        public event UpdateDelegate UpdateOrderPage;

        public OrderItem()
        {
            InitializeComponent();
            Loaded += OrderItem_Loaded;
        }

        public OrderItem(OrderItem item)
        {
            InitializeComponent();
            Title = item.Title;
            ImageSource = item.ImageSource;
            PricePerItem = item.PricePerItem;
            Quantity = item.Quantity;
            Modifications = item.Modifications;
            Loaded += OrderItem_Loaded;
        }

        private void OrderItem_Loaded( object sender, RoutedEventArgs e )
        {
            PriceTotal = PricePerItem * Quantity;
            if ( Quantity == 1 ) DecreaseButton.IsEnabled = false;

            foreach (string modification in Modifications)
            {
                ModificationList.Children.Add( new TextBlock
                {
                    FontSize = 12,
                    Foreground = new SolidColorBrush(Colors.DarkSlateGray),
                    TextWrapping = TextWrapping.Wrap,
                    Text = modification
                } );
            }
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
  
        }

        private void RemoveClick( object sender, RoutedEventArgs e )
        {

        }

        private void DecreaseClick(object sender, RoutedEventArgs e)
        {
            if ( Quantity <= 1 ) return;

            Quantity--;
            PriceTotal = PricePerItem * Quantity;

            if ( Quantity == 1 ) DecreaseButton.IsEnabled = false;

            OrderItemData.UpdateQuantity( this );
            UpdateOrderPage.Invoke();
        }

        private void IncreaseClick(object sender, RoutedEventArgs e)
        {
            Quantity++;
            PriceTotal = PricePerItem * Quantity;
            
            if (!DecreaseButton.IsEnabled) DecreaseButton.IsEnabled = true;

            OrderItemData.UpdateQuantity( this );
            UpdateOrderPage.Invoke();
        }
    }
}
