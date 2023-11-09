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
using WpfApp.ViewModels.TouristViewModels;

namespace WpfApp.Views.TouristViews
{
    /// <summary>
    /// Interaction logic for BuyTicketView.xaml
    /// </summary>
    public partial class BuyTicketView : Window
    {
        public BuyTicketView(BuyTicketView buyTicketView, TourDbContext tourDbContext,  Tourist selectedTourist,ref Ticket ticket)
        {
            InitializeComponent();
            DataContext = new BuyTicketViewModel(this,ref textbox_CardNumber,ref textbox_CVC, ref tourDbContext,ref selectedTourist,ref ticket);
        }
    }
}
