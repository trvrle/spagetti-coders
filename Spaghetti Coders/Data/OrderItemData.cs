using Spaghetti_Coders.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Text;

namespace Spaghetti_Coders.Data
{
    public static class OrderItemData
    {
        private static List<OrderItem> orderItems = new List<OrderItem>
        {
            new OrderItem
            {
                Title = "Spicy Ramen",
                ImageSource = new BitmapImage( new Uri( "/Images/spicy-ramen.jpg", UriKind.Relative ) ),
                PricePerItem = 9.99F,
                Quantity = 1,
                Comments = "hello spicy ramen comments"
            },
            new OrderItem
            {
                Title = "Tempura",
                ImageSource = new BitmapImage( new Uri( "/Images/tempura.jpg", UriKind.Relative ) ),
                PricePerItem = 9.99F,
                Quantity = 1
            },
            new OrderItem
            {
                Title = "Tempura",
                ImageSource = new BitmapImage( new Uri( "/Images/tempura.jpg", UriKind.Relative ) ),
                PricePerItem = 9.99F,
                Quantity = 1
            }
        };

        public static void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add( orderItem );
        }

        public static List<OrderItem> GetOrderItems()
        {
            return orderItems;
        }
    }
}
