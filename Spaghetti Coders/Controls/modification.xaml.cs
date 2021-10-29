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
    /// Interaction logic for modification.xaml
    /// </summary>
    public partial class Modification : UserControl
    {
        public Modification()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Menu), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModProperty =
   DependencyProperty.Register("ModOne", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModTwoProperty =
   DependencyProperty.Register("ModTwo", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModThreeProperty =
   DependencyProperty.Register("ModThree", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty RadioNameProperty =
   DependencyProperty.Register("RadioName", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string ModOne
        {
            get { return (string)GetValue(ModProperty); }
            set { SetValue(ModProperty, value); }
        }

        public string ModTwo
        {
            get { return (string)GetValue(ModTwoProperty); }
            set { SetValue(ModTwoProperty, value); }
        }

        public string ModThree
        {
            get { return (string)GetValue(ModThreeProperty); }
            set { SetValue(ModThreeProperty, value); }
        }

        public string RadioName
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
