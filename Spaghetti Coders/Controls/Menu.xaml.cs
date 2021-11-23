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
            Loaded += Menu_Loaded;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            FoodItemList.Children.Clear();
            var results = FoodItemData.GetFoodItemList().FindAll( item => item.Categories.Exists( category => category.Value.Equals(Title)) ) ;
            results.ForEach( delegate ( FoodItem foodItem )
             {
                 foodItem.Click += OnFoodItemClick;
                 FoodItemList.Children.Add( foodItem );
             } );
        }

        private void OnFoodItemClick( object sender, RoutedEventArgs e )
        {
            ItemSpicyRamen window = new ItemSpicyRamen();
            this.Content = window.Content;
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
                

            }

        }
        
    }
}
