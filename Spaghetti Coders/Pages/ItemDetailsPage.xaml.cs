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
using Spaghetti_Coders.Controls;

namespace Spaghetti_Coders.Pages
{
    /// <summary>
    /// Interaction logic for ItemDetailsPage.xaml
    /// </summary>
    public partial class ItemDetailsPage : Page
    {

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register( "Title", typeof( string ), typeof( ItemDetailsPage ), new PropertyMetadata( string.Empty ) );

        public string Title
        {
            get { return (string)GetValue( TitleProperty ); }
            set { SetValue( TitleProperty, value ); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register( "ImageSource", typeof( ImageSource ), typeof( ItemDetailsPage ), new PropertyMetadata( null ) );

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue( ImageSourceProperty ); }
            set { SetValue( ImageSourceProperty, value ); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register( "Description", typeof( string ), typeof( ItemDetailsPage ), new PropertyMetadata( string.Empty ) );

        public string Description
        {
            get { return (string)GetValue( DescriptionProperty ); }
            set { SetValue( DescriptionProperty, value ); }
        }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register( "Price", typeof( string ), typeof( ItemDetailsPage ), new PropertyMetadata( string.Empty ) );

        public string Price
        {
            get { return (string)GetValue( PriceProperty ); }
            set { SetValue( PriceProperty, value ); }
        }

        public ItemDetailsPage()
        {
            InitializeComponent();
        }

        public ItemDetailsPage(FoodItem foodItem)
        {
            InitializeComponent();
            Title = foodItem.Title;
            ImageSource = foodItem.ImageSource;
            Description = foodItem.Description;
            Price = foodItem.Price;
        }

        private void BackButton_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.GoBack();
        }

        private void ItemClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());
        }

        private void ModClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Modification());
        }
    }
}
