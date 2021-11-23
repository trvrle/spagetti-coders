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
using Spaghetti_Coders.Data;

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
                Title = FoodCategory.Specials.Value
            };

            MainTab.Content = new Menu
            {
                Title = FoodCategory.Main.Value
            };

            SidesTab.Content = new Menu
            {
                Title = FoodCategory.Sides.Value
            };

            DessertsTab.Content = new Menu
            {
                Title = FoodCategory.Desserts.Value
            };

            DrinksTab.Content = new Menu
            {
                Title = FoodCategory.Drinks.Value
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

