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
using Spaghetti_Coders.Popups;

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void OrderButton_Click( object sender, RoutedEventArgs e )
        {
            OrderPopup orderPopup = new OrderPopup();
            orderPopup.Show();
        }

        private void PayButton_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate( new PaymentPage() );
        }

        private void BackButton_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.GoBack();
        }
    }
}
