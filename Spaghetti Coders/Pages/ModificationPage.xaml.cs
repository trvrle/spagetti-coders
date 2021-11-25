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

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for modification.xaml
    /// </summary>
    public partial class ModificationPage : Page
    {
        public ModificationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(AddItem))
            {
                //navigate to order screen-- check once item hooked up
                NavigationService.Navigate(new OrderPage());

                //add item to order 

            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
