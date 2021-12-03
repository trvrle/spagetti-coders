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
    /// Interaction logic for PaymentList.xaml
    /// </summary>
    public partial class PaymentList : UserControl
    {
        public PaymentList()
        {
            InitializeComponent();
            Loaded += PaymentList_Loaded;
        }

        private void PaymentList_Loaded( object sender, RoutedEventArgs e )
        {
            List<OrderItem> orderedItems = OrderItemData.GetOrderedItemsForPayment();

            PaymentItemList.Children.Clear();

            foreach ( OrderItem item in orderedItems )
            {
                PaymentItemList.Children.Add( new PaymentItem(item) );
            }
        }
    }
}
