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

namespace Spaghetti_Coders
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Order))
            {
                OrderPopUp order = new OrderPopUp();
                order.Show();
               
            }
            else if (sender.Equals(Pay))
            {
                PaymentWindow paymentWindow = new PaymentWindow();
                paymentWindow.Show();
            }
        }

        private void BackButton_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.GoBack();
        }
    }
}
