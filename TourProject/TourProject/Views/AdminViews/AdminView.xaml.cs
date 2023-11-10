using Databases.Contexts;
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
using TourProject.ViewModels.AdminViewModels;

namespace TourProject.Views.AdminViews
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        private TourDbContext DbContext = new();
        public AdminView()
        {
            InitializeComponent();
            DataContext = new AdminViewModel(this, ref DbContext);
        }
    }
}
