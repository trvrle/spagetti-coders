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
    /// Interaction logic for OrderItem.xaml
    /// </summary>
    public partial class OrderItem : UserControl
    {

        public static readonly DependencyProperty CommentsProperty =
            DependencyProperty.Register( "Comments", typeof( string ), typeof( OrderItem ), new PropertyMetadata( string.Empty ) );

        public string Comments
        {
            get { return (string)GetValue( CommentsProperty ); }
            set { SetValue( CommentsProperty, value ); }
        }

        public OrderItem()
        {
            InitializeComponent();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            
        }

        public int amount = 0;
        private void decreaseClick(object sender, RoutedEventArgs e)
        {
            if (amount > 0)
            {
                amount--;
            }

            Quantity.Content = amount.ToString();
        }

        private void increaseClick(object sender, RoutedEventArgs e)
        {
            amount++;

            Quantity.Content = amount.ToString();
        }
    }
}
