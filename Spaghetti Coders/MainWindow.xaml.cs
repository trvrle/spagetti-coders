using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spaghetti_Coders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 700;

        }
        public static Window GetParentWindow(DependencyObject obj)
        {
            return (Window)obj.GetValue(ParentWindowProperty);
        }
        public static void SetParentWindow(DependencyObject obj, Window value)
        {
            obj.SetValue(ParentWindowProperty, value);
        }
        public static readonly DependencyProperty ParentWindowProperty =
            DependencyProperty.RegisterAttached("ParentWindow", typeof(Window), typeof(MainWindow), new PropertyMetadata(null));
    }
}

