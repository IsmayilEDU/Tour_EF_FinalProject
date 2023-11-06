using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WPF.Views.StartViews;

namespace WPF.Views.AdminViews.Windows
{
    /// <summary>
    /// Interaction logic for TouristView.xaml
    /// </summary>
    public partial class TouristView : Window
    {
        public TouristView()
        {
            InitializeComponent();
            DataContext = this;
            ListOTours.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginView secondWindow = new();
            secondWindow.Show(); // Show the second window
            this.Close(); // Close the current window
        }
    }
}
