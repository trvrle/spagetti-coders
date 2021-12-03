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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public OrderList()
        {
            InitializeComponent();
            Loaded += OrderList_Loaded;
        }

        private void OrderList_Loaded( object sender, RoutedEventArgs e )
        {
            List<OrderItem> orderItemList = OrderItemData.GetOrderItems();

            foreach(OrderItem item in orderItemList)
            {
                OrderItemList.Children.Add( item );
            }
        }
    }
}
