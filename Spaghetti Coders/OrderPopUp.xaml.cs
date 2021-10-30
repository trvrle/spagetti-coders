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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Spaghetti_Coders
{
    /// <summary>
    /// Interaction logic for OrderPopUp.xaml
    /// </summary>
    public partial class OrderPopUp : Window
    {
        public OrderPopUp()
        {
            InitializeComponent();

            this.Owner = App.Current.MainWindow;

        }
       
    }
}