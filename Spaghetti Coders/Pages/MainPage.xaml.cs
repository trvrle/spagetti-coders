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
using System.Diagnostics;
using Spaghetti_Coders.Data;
using Spaghetti_Coders.Controls;
using Menu = Spaghetti_Coders.Controls.Menu;

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            SpecialsTab.Content = new Menu
            {
                Title = FoodCategory.Specials.Value
            };
            ( SpecialsTab.Content as Menu ).OnFoodItemClick += new Menu.OnFoodItemClickDelegate( OnItemClick );
            ( SpecialsTab.Content as Menu ).OnOrderButtonClick += new Menu.OnOrderButtonClickDelegate( OnOrderButtonClick );

            MainTab.Content = new Menu
            {
                Title = FoodCategory.Main.Value
            };
            ( MainTab.Content as Menu ).OnFoodItemClick += new Menu.OnFoodItemClickDelegate( OnItemClick );
            ( MainTab.Content as Menu ).OnOrderButtonClick += new Menu.OnOrderButtonClickDelegate( OnOrderButtonClick );

            SidesTab.Content = new Menu
            {
                Title = FoodCategory.Sides.Value
            };
            ( SidesTab.Content as Menu ).OnFoodItemClick += new Menu.OnFoodItemClickDelegate( OnItemClick );
            ( SidesTab.Content as Menu ).OnOrderButtonClick += new Menu.OnOrderButtonClickDelegate( OnOrderButtonClick );

            DessertsTab.Content = new Menu
            {
                Title = FoodCategory.Desserts.Value
            };
            ( DessertsTab.Content as Menu ).OnFoodItemClick += new Menu.OnFoodItemClickDelegate( OnItemClick );
            ( DessertsTab.Content as Menu ).OnOrderButtonClick += new Menu.OnOrderButtonClickDelegate( OnOrderButtonClick );

            DrinksTab.Content = new Menu
            {
                Title = FoodCategory.Drinks.Value
            };
            ( DrinksTab.Content as Menu ).OnFoodItemClick += new Menu.OnFoodItemClickDelegate( OnItemClick );
            ( DrinksTab.Content as Menu ).OnOrderButtonClick += new Menu.OnOrderButtonClickDelegate( OnOrderButtonClick );
        }

        private void OnItemClick(FoodItem foodItem)
        {
            NavigationService.Navigate( new ItemDetailsPage(foodItem) );
        }

        private void OnOrderButtonClick()
        {
            NavigationService.Navigate( new OrderPage() );
        }


        private void Button_Click( object sender, RoutedEventArgs e )
        {
            if ( sender.Equals( Bell ) )
            {
                BellPopUp bellPopUp = new BellPopUp();
                bellPopUp.Show();

            }
        }
    }
}
