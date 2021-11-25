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

        public delegate void OnFoodItemClickDelegate( FoodItem foodItem );

        public event OnFoodItemClickDelegate OnFoodItemClick;

        public delegate void OnOrderButtonClickDelegate();

        public event OnOrderButtonClickDelegate OnOrderButtonClick;

        public delegate void OnPayButtonClickDelegate();

        public event OnPayButtonClickDelegate OnPayButtonClick;

        public Menu()
        {
            InitializeComponent();
            Loaded += Menu_Loaded;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            FoodItemList.Children.Clear();
            var foodItemsInCategory = FoodItemData.GetFoodItemList().FindAll( item => item.Categories.Exists( category => category.Value.Equals(Title)) ) ;
            foodItemsInCategory.ForEach( delegate ( FoodItem foodItem )
             {
                 foodItem.Click += FoodItemClick;
                 FoodItemList.Children.Add( foodItem );
             } );
        }

        private void FoodItemClick(object sender, RoutedEventArgs e)
        {
            OnFoodItemClick?.Invoke( ( sender as FoodItem ) );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(OrderButton))
            {
                OnOrderButtonClick?.Invoke( );
            }

            if (sender.Equals(SortButton))
            {
                

            }

        }
        
    }
}
