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
using Spaghetti_Coders.Pages;

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

        public static readonly DependencyProperty NumberOfItemsProperty =
            DependencyProperty.Register( "NumberOfItems", typeof( string ), typeof( Menu ), new PropertyMetadata( string.Empty ) );

        public string NumberOfItems
        {
            get { return (string)GetValue( NumberOfItemsProperty ); }
            set { SetValue( NumberOfItemsProperty, value ); }
        }

        public SortMethod sortMethod = SortMethod.None;

        private List<SortButton> sortButtons;

        public delegate void OnFoodItemClickDelegate( FoodItem foodItem );

        public event OnFoodItemClickDelegate OnFoodItemClick;

        public delegate void OnOrderButtonClickDelegate();

        public event OnOrderButtonClickDelegate OnOrderButtonClick;

        public delegate void OnSetSortMethodDelegate( SortMethod sortMethod );

        public event OnSetSortMethodDelegate OnSetSortMethod;

        public Menu()
        {
            InitializeComponent();
            Loaded += LoadMenu;
            sortButtons = new List<SortButton> {
                PriceAscending_Button,
                PriceDescending_Button,
                CaloriesAscending_Button,
                CaloriesDescending_Button
            };
        }

        private void LoadMenu( object sender, RoutedEventArgs e)
        {
            LoadNumberOfItemsCanOrder();
            LoadFoodItems();
            LoadSortButtons();
        }

        private void LoadNumberOfItemsCanOrder()
        {
            int count = OrderItemData.GetNumberOfItemsCanOrder();
            if ( count == 0 )
            {
                NumOfItemsBackground.Visibility = Visibility.Hidden;
                NumOfItemsText.Visibility = Visibility.Hidden;
            }
            else
            {
                NumOfItemsBackground.Visibility = Visibility.Visible;
                NumOfItemsText.Visibility = Visibility.Visible;
                if ( count > 9 )
                    count = 9;
                NumberOfItems = count.ToString();
            }
        }

        private void LoadFoodItems()
        {
            FoodItemList.Children.Clear();

            List<FoodItem> foodItems = GetFoodItems();
            
            foodItems.ForEach( delegate ( FoodItem foodItem )
            {
                foodItem.Click += FoodItemClick;
                FoodItemList.Children.Add( foodItem );
            } );
        }

        private List<FoodItem> GetFoodItems()
        {
            List<FoodItem> foodItemsInCategory = FoodItemData.GetFoodItemList().FindAll( item => item.Categories.Exists( category => category.Value.Equals( Title ) ) );

            switch ( sortMethod )
            {
                case SortMethod.PriceAscending:
                    foodItemsInCategory.Sort( delegate ( FoodItem item1, FoodItem item2 ) {
                        float item1Discount = item1.Discount ?? 0;
                        float item2Discount = item2.Discount ?? 0;
                        return (int)( item1.Price - item1Discount - ( item2.Price - item2Discount ) );
                    } );
                    break;
                case SortMethod.PriceDescending:
                    foodItemsInCategory.Sort( delegate ( FoodItem item1, FoodItem item2 ) {
                        float item1Discount = item1.Discount ?? 0;
                        float item2Discount = item2.Discount ?? 0;
                        return (int)( item2.Price - item2Discount - ( item1.Price - item1Discount ) );
                    } );
                    break;
                case SortMethod.CaloriesAscending:
                    foodItemsInCategory.Sort( delegate ( FoodItem item1, FoodItem item2 ) { return item1.Calories - item2.Calories; } );
                    break;
                case SortMethod.CaloriesDescending:
                    foodItemsInCategory.Sort( delegate ( FoodItem item1, FoodItem item2 ) { return item2.Calories - item1.Calories; } );
                    break;
            }

            return foodItemsInCategory;
        }

        private void LoadSortButtons()
        {
            PriceAscending_Button.ActiveSortMethod = SortMethod.PriceAscending;
            PriceDescending_Button.ActiveSortMethod = SortMethod.PriceDescending;
            CaloriesAscending_Button.ActiveSortMethod = SortMethod.CaloriesAscending;
            CaloriesDescending_Button.ActiveSortMethod = SortMethod.CaloriesDescending;

            foreach(SortButton button in sortButtons)
            {
                button.OnSortButtonClicked += new SortButton.OnSortButtonClickedDelegate( OnSortButtonClicked );
                button.SetSortMethod( sortMethod );
            }

            if ( sortButtons.Exists( button => button.Active ) )
            {
                SortMenu_Button.Background = Brushes.LightBlue;
            }
        }

        private void FoodItemClick(object sender, RoutedEventArgs e)
        {
            OnFoodItemClick.Invoke( sender as FoodItem );
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            OnOrderButtonClick?.Invoke( );
        }

        private void SortMenuButton_Click( object sender, RoutedEventArgs e )
        {
            if ( SortMenu.Visibility == Visibility.Hidden )
                SortMenu.Visibility = Visibility.Visible;
            else
                SortMenu.Visibility = Visibility.Hidden;
        }

        private void OnSortButtonClicked(SortMethod sortMethodClicked)
        {
            foreach(SortButton button in sortButtons)
            {
                button.SetSortMethod( sortMethodClicked );
            }

            if ( sortButtons.Exists( button => button.Active ) )
            {
                SortMenu_Button.Background = Brushes.LightBlue;
            }
            else
                SortMenu_Button.Background = new SolidColorBrush( Color.FromRgb( 0xD5, 0x71, 0x74 ) );

            OnSetSortMethod.Invoke( sortMethodClicked );

            LoadFoodItems();
            SortMenu.Visibility = Visibility.Hidden;
        }

    }
}
