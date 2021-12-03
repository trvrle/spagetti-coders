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
using System.Windows.Shapes;

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        public static readonly DependencyProperty SubtotalProperty =
            DependencyProperty.Register( "Subtotal", typeof( string ), typeof( PaymentPage ), new PropertyMetadata( "$-" ) );

        public float Subtotal
        {
            get { return PriceStringToFloat( (string)GetValue( SubtotalProperty ) ); }
            set
            {
                SetValue( SubtotalProperty, FloatToPriceString( value ) );
                GST = value * 5 / 100;
                Total = value + GST;
            }
        }

        public static readonly DependencyProperty GSTProperty =
            DependencyProperty.Register( "GST", typeof( string ), typeof( PaymentPage ), new PropertyMetadata( "$-" ) );

        public float GST
        {
            get { return PriceStringToFloat( (string)GetValue( GSTProperty ) ); }
            set { SetValue( GSTProperty, FloatToPriceString( value ) ); }
        }

        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register( "Total", typeof( string ), typeof( PaymentPage ), new PropertyMetadata( "$-" ) );

        public float Total
        {
            get { return PriceStringToFloat( (string)GetValue( TotalProperty ) ); }
            set { SetValue( TotalProperty, FloatToPriceString( value ) ); }
        }

        private float PriceStringToFloat( string s )
        {
            if ( s.Equals( "$-" ) )
                return 0;
            return float.Parse( s.Replace( "$", "" ) );
        }

        private string FloatToPriceString( float f )
        {
            if ( f == 0 )
                return "$-";
            return $"${f:0.00}";
        }

        public PaymentPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
