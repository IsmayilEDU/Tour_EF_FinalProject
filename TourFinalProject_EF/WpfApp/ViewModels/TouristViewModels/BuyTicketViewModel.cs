using Database.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels.TouristViewModels
{
    internal class BuyTicketViewModel : ITourDBContext
    {
        public TourDbContext DbContext { get ; set ; }
    }
}
