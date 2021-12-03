using Spaghetti_Coders.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Text;

namespace Spaghetti_Coders.Data
{
    public static class OrderItemData
    {
        private static List<OrderItem> orderItems = new List<OrderItem>();

        public static int Count { 
            get { return orderItems.Count; }
        }

        public static void AddOrderItem(OrderItem orderItem)
        {
            OrderItem findItem = orderItems.Find( item => item.Title == orderItem.Title );
            if ( findItem != null )
            {
                findItem.Quantity++;
                findItem.PriceTotal = findItem.Quantity * findItem.PricePerItem;
            }
            else
                orderItems.Add( orderItem );
        }

        public static List<OrderItem> GetOrderItems()
        {
            List<OrderItem> newOrderItems = new List<OrderItem>();

            foreach(OrderItem item in orderItems)
            {
                newOrderItems.Add( new OrderItem( item ) );
            }

            return newOrderItems;
        }

        public static float GetTotalOrderItemPrice()
        {
            if ( orderItems.Count < 1 )
                return 0;
            float sum = 0;

            foreach(OrderItem item in orderItems)
            {
                sum += item.PriceTotal;
            }

            return sum;
        }

        public static void UpdateQuantity(OrderItem orderItem)
        {
            OrderItem findItem = orderItems.Find( item => item.Title == orderItem.Title );
            if ( findItem != null )
            {
                findItem.Quantity = orderItem.Quantity;
                findItem.PriceTotal = orderItem.PriceTotal;
            }
        }
    }
}
