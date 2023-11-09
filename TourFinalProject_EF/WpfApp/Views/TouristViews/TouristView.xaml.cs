using Database.Contexts;
using Models.Entities.DerivedEntities;
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
using System.Windows.Shapes;
using WpfApp.ViewModels;
using WpfApp.Views.StartViews;

namespace WpfApp.Views.TouristViews
{
    /// <summary>
    /// Interaction logic for TouristView.xaml
    /// </summary>
    public partial class TouristView : Window
    {
        TouristViewModel touristViewModel;
        public TouristView(ref TourDbContext dbContext, ref Tourist SelectedTourist)
        {
            InitializeComponent();
            touristViewModel = new(this,ref dbContext,ref SelectedTourist);
            DataContext = touristViewModel;
            ListOTours.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginView secondWindow = new();
            secondWindow.Show(); // Show the second window
            this.Close(); // Close the current window
        }

        private void ListOfLocationsName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            touristViewModel.SelectedItem
        }
    }
}
