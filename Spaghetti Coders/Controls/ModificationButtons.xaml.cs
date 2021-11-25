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
    /// Interaction logic for ModificationButtons.xaml
    /// </summary>
    public partial class ModificationButtons : UserControl
    {

        public static readonly DependencyProperty TProperty =
    DependencyProperty.Register("Select", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModProperty =
    DependencyProperty.Register("ModOne", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModTwoProperty =
    DependencyProperty.Register("ModTwo", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ModThreeProperty =
    DependencyProperty.Register("ModThree", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty RadioNameProperty =
   DependencyProperty.Register("RadioName", typeof(string), typeof(ModificationButtons), new PropertyMetadata(string.Empty));

        public string Select
        {
            get { return (string)GetValue(TProperty); }
            set { SetValue(TProperty, value); }
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

        public ModificationButtons()
        {
            InitializeComponent();
        }
    }
}
