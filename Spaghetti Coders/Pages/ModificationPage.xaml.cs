using Spaghetti_Coders.Controls;
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

        public ModificationPage(FoodItem foodItem)
        {
            InitializeComponent();
            ImageSource = foodItem.ImageSource;
            Title = foodItem.Title;

            Loaded += ModificationPageLoaded;
        }

        private void ModificationPageLoaded(object sender, RoutedEventArgs e)
        {
            NoMods.Visibility = Visibility.Hidden;

            List<FoodItem> FoodItemList = FoodItemData.GetFoodItemList();
            Dictionary<string, List<string>> modifications = FoodItemList.Find(item => item.Title == Title).Modifications;

            if(modifications.Count != 0)
            {
                foreach (KeyValuePair<string, List<string>> mod in modifications)
                {

                    String ModificationName = mod.Key;
                    List<string> ModificationValues = mod.Value;

                    ModificationButtons button = new ModificationButtons
                    {
                        RadioName = mod.Key,
                        Select = mod.Key,
                        ModOne = mod.Value[0],
                        ModTwo = mod.Value[1],
                        ModThree = mod.Value[2]
                    };

                    ModificationList.Children.Add(button);
                }
            } else
            {
                NoMods.Visibility = Visibility.Visible;
            }
        }

        public static readonly DependencyProperty TitleProperty =
             DependencyProperty.Register("Title", typeof(string), typeof(ModificationPage), new PropertyMetadata(string.Empty));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ModificationPage), new PropertyMetadata(null));

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
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

        // Opening keyboard + textbox
        private void Extra_Click_Open(object sender, EventArgs e)
        {
            Extra.Visibility = Visibility.Visible;
            Extra1.Text = (sender as TextBox).Text;
            Keyboard.Visibility = Visibility.Visible;
        }

        // Closing keyboard + textbox and moving text to first textbox
        private void Extra_Click_Close(object sender, EventArgs e)
        {
            Extra.Visibility = Visibility.Hidden;
            Keyboard.Visibility = Visibility.Hidden;
            Extra1.Text = (sender as TextBox).Text;
            Extra1.Foreground = Brushes.Black;
        }

        // Start close event when enter is clicked
        private void KeyTest(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Extra_Click_Close(sender, e);
            }
        }
    }
}
