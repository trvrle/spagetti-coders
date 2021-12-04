using Spaghetti_Coders.Data;
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

namespace Spaghetti_Coders.Controls
{

    /// <summary>
    /// Interaction logic for SortButton.xaml
    /// </summary>
    public partial class SortButton : UserControl
    {
        public static readonly DependencyProperty SortNameProperty =
            DependencyProperty.Register( "SortName", typeof( string ), typeof( SortButton ), new PropertyMetadata( string.Empty ) );

        public string SortName
        {
            get { return (string)GetValue( SortNameProperty ); }
            set { SetValue( SortNameProperty, value ); }
        }

        public static readonly DependencyProperty SortTypeImageProperty =
               DependencyProperty.Register( "SortTypeImage", typeof( ImageSource ), typeof( SortButton ), new PropertyMetadata( null ) );

        public ImageSource SortTypeImage
        {
            get { return (ImageSource)GetValue( SortTypeImageProperty ); }
            set { SetValue( SortTypeImageProperty, value ); }
        }

        public static readonly DependencyProperty SortDirectionImageProperty =
               DependencyProperty.Register( "SortDirectionImage", typeof( ImageSource ), typeof( SortButton ), new PropertyMetadata( null ) );

        public ImageSource SortDirectionImage
        {
            get { return (ImageSource)GetValue( SortDirectionImageProperty ); }
            set { SetValue( SortDirectionImageProperty, value ); }
        }

        public SortMethod ActiveSortMethod;

        public bool Active
        {
            get
            {
                if ( Background == Brushes.LightBlue )
                    return true;
                else
                    return false;
            }
            set
            {
                if ( value )
                    Background = Brushes.LightBlue;
                else
                    Background = Brushes.Transparent;
            }
        }

        public delegate void OnSortButtonClickedDelegate( SortMethod sortMethod );

        public event OnSortButtonClickedDelegate OnSortButtonClicked;

        public SortButton()
        {
            InitializeComponent();
        }

        public void SetSortMethod(SortMethod sortMethod)
        {
            Active = sortMethod == ActiveSortMethod;
        }

        private void SortButton_Clicked( object sender, RoutedEventArgs e )
        {
            if ( Active )
                OnSortButtonClicked.Invoke( SortMethod.None );
            else
                OnSortButtonClicked.Invoke( ActiveSortMethod );
        }
    }
}
