using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Spaghetti_Coders.Controls;

namespace Spaghetti_Coders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SpecialsTab.Content = new Menu
            {
                Title = "Today's Specials"
            };

            MainTab.Content = new Menu
            {
                Title = "Main"
            };

            SidesTab.Content = new Menu
            {
                Title = "Sides"
            };

            DessertsTab.Content = new Menu
            {
                Title = "Desserts"
            };

            DrinksTab.Content = new Menu
            {
                Title = "Drinks"
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Bell))
            {
                BellPopUp bellPopUp = new BellPopUp();
                bellPopUp.Show();

            }

        }
    }
}

