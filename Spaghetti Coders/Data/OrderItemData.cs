using Spaghetti_Coders.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Text;
using System.Linq;

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
            OrderItem findItem = orderItems.Find( item => item.Title == orderItem.Title && Enumerable.SequenceEqual(item.Modifications, orderItem.Modifications) );
            if ( findItem != null )
            {
                findItem.Quantity++;
                findItem.PriceTotal = findItem.Quantity * findItem.PricePerItem;
            }
            else
                orderItems.Add( orderItem );
        }

        public static void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItem findItem = orderItems.Find( item => item.Title == orderItem.Title && Enumerable.SequenceEqual( item.Modifications, orderItem.Modifications ) );
            if (findItem != null)
            {
                orderItems.Remove( findItem );
            }
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

        public static void Order()
        {
            foreach(OrderItem item in orderItems)
            {
                item.Ordered = true;
            }
        }

        public static bool CanOrder()
        {
            return orderItems.Exists( item => !item.Ordered );
        }

        public static bool CanPay()
        {
            return orderItems.Exists( item => item.Ordered );
        }

        public static List<OrderItem> GetOrderedItemsForPayment()
        {
            return orderItems.FindAll( item => item.Ordered );
        }

        public static float GetPaymentPrice()
        {
            List<OrderItem> orderedItems = orderItems.FindAll( item => item.Ordered );
            float sum = 0;

            foreach ( OrderItem item in orderedItems )
            {
                sum += item.PriceTotal;
            }

            return sum;
        }
    }
}
