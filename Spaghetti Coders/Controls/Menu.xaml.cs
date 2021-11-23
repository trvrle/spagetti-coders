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

        Dictionary<string, FoodItem> foodItemDictionary = new Dictionary<string, FoodItem>
        {
            {
                "Spicy Ramen",
                new FoodItem
                    {
                        Title = "Spicy Ramen",
                        Description = "Spicy miso based soup topped with sesame, green onions, corn seeds, beansprouts, enoki mushrooms, and egg.",
                        ImageSource = new BitmapImage( new Uri( "/Images/spicy-ramen.jpg", UriKind.Relative ) ),
                        Price = "$12.99"
                    }
            },
            {
                "Tempura",
                new FoodItem
                    {
                        Title = "Tempura",
                        Description = "Fresh shrimp dipped in tempura batter and deep-fried until perfectly crispy.",
                        ImageSource = new BitmapImage( new Uri( "/Images/tempura.jpg", UriKind.Relative ) ),
                        Price = "$11.99"
                    }
            },
            {
                "Miso Ramen",
                new FoodItem
                    {
                        Title = "Miso Ramen",
                        Description = "Miso ramen soup topped with sesame, green onions, seaweed, carrots, and egg.",
                        ImageSource = new BitmapImage( new Uri( "/Images/miso-ramen.jpg", UriKind.Relative ) ),
                        Price = "$12.99"
                    }
            },
            {
                "California Roll",
                new FoodItem
                    {
                        Title = "California Roll",
                        Description = "California Rolls with a layer of rice on the outside and a sheet of nori on the inside, and include avocado, imitation crab, cucumber, and tobiko (flying fish roe).",
                        ImageSource = new BitmapImage( new Uri( "/Images/california-roll.jpg", UriKind.Relative ) ),
                        Price = "$8.99"
                    }
            },
            {
                "Tuna Roll",
                new FoodItem
                    {
                        Title = "Tuna Roll",
                        Description = "Tuna Rolls with sashimi grade tuna tossed in sesame Sriracha sauce, topped with spicy mayo.",
                        ImageSource = new BitmapImage( new Uri( "/Images/spicy-ramen.jpg", UriKind.Relative ) ),
                        Price = "$12.99"
                    }
            },
            {
                "Salmon Sushi Roll",
                new FoodItem
                    {
                        Title = "Salmon Sushi Roll",
                        Description = "Salmon Sushi Roll made from raw salmon, spicy sauce (Japanese-style mayonnaise mixed with chili sauce), and sushi rice, wrapped in nori (seaweed).",
                        ImageSource = new BitmapImage( new Uri( "/Images/salmon-sushi-roll.jpg", UriKind.Relative ) ),
                        Price = "$8.99"
                    }
            },
            {
                "Salmon Sushi",
                new FoodItem
                    {
                        Title = "Salmon Sushi",
                        Description = "Salmon Sushi Description",
                        ImageSource = new BitmapImage( new Uri( "/Images/spicy-ramen.jpg", UriKind.Relative ) ),
                        Price = "$8.99"
                    }
            }
        };

        public Menu()
        {
            InitializeComponent();
            Loaded += Menu_Loaded;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            List<FoodItem> foodItemList = new List<FoodItem>();
            
            if (Title.Equals("Today's Specials"))
            {
                foodItemList.Add( foodItemDictionary["Spicy Ramen"] );
                foodItemList.Add( foodItemDictionary["Miso Ramen"] );
                foodItemList.Add( foodItemDictionary["Tempura"] );
            }
            else
            {
                foodItemList.Add( foodItemDictionary["Spicy Ramen"] );
                foodItemList.Add( foodItemDictionary["Miso Ramen"] );
                foodItemList.Add( foodItemDictionary["California Roll"] );
            }

            FoodItemList.Children.Clear();
            foodItemList.ForEach( delegate ( FoodItem foodItem )
             {
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
