using System.Windows;
using Spaghetti_Coders.Pages;

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
            mainFrame.Navigate( new MainPage() );
        }

    }
}

