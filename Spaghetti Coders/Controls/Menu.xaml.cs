﻿using System;
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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register( "Title", typeof( string ), typeof( Menu ), new PropertyMetadata( string.Empty ) );
        
        public string Title
        {
            get { return (string)GetValue( TitleProperty ); }
            set { SetValue( TitleProperty, value ); }
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void OnFoodItemClick( object sender, RoutedEventArgs e )
        {
             
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(OrderButton))
            {
                OrderPage order = new OrderPage();
                this.Content = order.Content;

            }

            if (sender.Equals(SortButton))
            {

                Sorting sort = new Sorting();
                sort.Show();
            }

        }
        
    }
}
