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
    /// Interaction logic for PaymentItem.xaml
    /// </summary>
    public partial class PaymentItem : UserControl
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register( "Title", typeof( string ), typeof( PaymentItem ), new PropertyMetadata( string.Empty ) );

        public string Title
        {
            get { return (string)GetValue( TitleProperty ); }
            set { SetValue( TitleProperty, value ); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register( "ImageSource", typeof( ImageSource ), typeof( PaymentItem ), new PropertyMetadata( null ) );

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue( ImageSourceProperty ); }
            set { SetValue( ImageSourceProperty, value ); }
        }

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register( "Quantity", typeof( string ), typeof( PaymentItem ), new PropertyMetadata( string.Empty ) );

        public int Quantity
        {
            get { return int.Parse( ((string)GetValue( QuantityProperty )).Replace("x", "") ); }
            set { SetValue( QuantityProperty, $"x{value}" ); }
        }

        public static readonly DependencyProperty PriceTotalProperty =
            DependencyProperty.Register( "PriceTotal", typeof( string ), typeof( PaymentItem ), new PropertyMetadata( string.Empty ) );

        public float PriceTotal
        {
            get { return float.Parse( ( (string)GetValue( PriceTotalProperty ) ).Replace( "$", "" ) ); }
            set { SetValue( PriceTotalProperty, $"${value:0.00}" ); }
        }

        public List<string> Modifications = new List<string>();

        public PaymentItem()
        {
            InitializeComponent();
        }

        public PaymentItem(OrderItem item)
        {
            InitializeComponent();
            Title = item.Title;
            ImageSource = item.ImageSource;
            Quantity = item.Quantity;
            PriceTotal = item.Quantity * item.PricePerItem;
            Modifications = item.Modifications;
            Loaded += PaymentItem_Loaded;
        }

        private void PaymentItem_Loaded( object sender, RoutedEventArgs e )
        {
            foreach ( string modification in Modifications )
            {
                ModificationList.Children.Add( new TextBlock
                {
                    FontSize = 12,
                    Foreground = new SolidColorBrush( Colors.DarkSlateGray ),
                    TextWrapping = TextWrapping.Wrap,
                    Text = modification
                } );
            }
        }
    }
}
