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
using Spaghetti_Coders.Data;

namespace Spaghetti_Coders.Controls
{
    /// <summary>
    /// Interaction logic for FoodItem.xaml
    /// </summary>
    public partial class FoodItem : UserControl
    {

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register( "ImageSource", typeof( ImageSource ), typeof( FoodItem ), new PropertyMetadata( null ) );

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue( ImageSourceProperty ); }
            set { SetValue( ImageSourceProperty, value ); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register( "Title", typeof( string ), typeof( FoodItem ), new PropertyMetadata( string.Empty ) );

        public string Title
        {
            get { return (string)GetValue( TitleProperty ); }
            set { SetValue( TitleProperty, value ); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register( "Description", typeof( string ), typeof( FoodItem ), new PropertyMetadata( string.Empty ) );

        public string Description
        {
            get { return (string)GetValue( DescriptionProperty ); }
            set { SetValue( DescriptionProperty, value ); }
        }

        public int Calories { get; set; }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register( "Price", typeof( string ), typeof( FoodItem ), new PropertyMetadata( string.Empty ) );

        public float Price
        {
            get { return float.Parse(((string)GetValue( PriceProperty )).Replace("$", "")); }
            set { SetValue( PriceProperty, $"${value:0.00}" ); }
        }

        public float? Discount { get; set; }

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register( "Quantity", typeof( string ), typeof( FoodItem ), new PropertyMetadata( string.Empty ) );

        public string Quantity
        {
            get { return ((string)GetValue( QuantityProperty )).Remove(0); }
            set { SetValue( QuantityProperty, $"/{value}" ); }
        }

        public static readonly RoutedEvent ClickEvent =
            EventManager.RegisterRoutedEvent( nameof(Click), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof( FoodItem ) );

        public event RoutedEventHandler Click
        {
            add { AddHandler( ClickEvent, value ); }
            remove { RemoveHandler( ClickEvent, value ); }
        }

        public List<FoodCategory> Categories;

        public FoodItem()
        {
            InitializeComponent();
            Loaded += FoodItem_Loaded;
        }

        private void FoodItem_Loaded( object sender, RoutedEventArgs e )
        {
            if ( !Discount.HasValue ) 
            {
                PriceTextBlock.TextDecorations = null;
                return;
            }

            float discountedPrice = Price - Discount.Value;
            DiscountedPriceTextBlock.Text = $"${discountedPrice:0.00}";
            DiscountedPriceTextBlock.Visibility = Visibility.Visible;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent( new RoutedEventArgs( ClickEvent ) );
        }
    }
}
