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
using System.Text.RegularExpressions;

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for modification.xaml
    /// </summary>
    public partial class ModificationPage : Page
    {
        private List<ModificationButtons> modificationButtons = new List<ModificationButtons>();

        public ModificationPage()
        {
            InitializeComponent();
            Loaded += ModificationPageLoaded;
        }

        private void ModificationPageLoaded(object sender, RoutedEventArgs e)
        {
            NoMods.Visibility = Visibility.Hidden;

            List<FoodItem> FoodItemList = FoodItemData.GetFoodItemList();
            Dictionary<string, List<string>> modifications = FoodItemList.Find(item => item.Title == Title).Modifications;

            if(modifications.Count != 0)
            {
                ModificationList.Children.Clear();
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

                    modificationButtons.Add( button );
                    ModificationList.Children.Add( button );
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

        public float Price = 0;

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            List<string> modificationStrings = new List<string>();

            float modificationPrice = 0;

            foreach(ModificationButtons modButton in modificationButtons)
            {
                string modification = modButton.GetModification();
                if ( !modification.Equals( "" ) )
                {
                    modificationStrings.Add( modification );
                    string priceString = Regex.Match( modification, "[0-9]+\\.+[0-9]+[0-9]+" ).ToString();
                    if(!priceString.Equals(""))
                        modificationPrice += float.Parse( priceString );
                }
            }

            if( SpecialInstructions_KeyboardTextBox.Text != "")
                modificationStrings.Add( SpecialInstructions_KeyboardTextBox.Text );

            OrderItemData.AddOrderItem( new OrderItem
            {
                Title = Title,
                ImageSource = ImageSource,
                PricePerItem = Price + modificationPrice,
                PriceTotal = Price + modificationPrice,
                Modifications = modificationStrings,
                Quantity = 1
            } );
            
            NavigationService.Navigate(new OrderPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        // Opening keyboard + textbox
        private void Click_OpenKeyboard(object sender, EventArgs e)
        {
            SpecialInstructions_KeyboardTextBox.Visibility = Visibility.Visible;
            SpecialInstructions_KeyboardTextBox.Focus();
            SpecialInstructions_TextBox.Text = (sender as TextBox).Text;
            Keyboard.Visibility = Visibility.Visible;
        }

        // Closing keyboard + textbox and moving text to first textbox
        private void Click_CloseKeyboard(object sender, EventArgs e)
        {
            SpecialInstructions_KeyboardTextBox.Visibility = Visibility.Hidden;
            Keyboard.Visibility = Visibility.Hidden;
            string text = ( sender as TextBox ).Text;
            if ( text.Equals( "" ) )
                text = "Enter Special Instructions...";
            SpecialInstructions_TextBox.Text = text;
            SpecialInstructions_TextBox.Foreground = Brushes.Black;
        }

        // Start close event when enter is clicked
        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Click_CloseKeyboard(sender, e);
            }
        }
    }
}
