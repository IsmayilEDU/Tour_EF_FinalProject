using AppSettings;
using Databases.Contexts;
using Databases.Contexts;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models.DTO;
using Models.Entities.DerivedEntities;
using System.Collections.Generic;
using System.Linq;
using TourProject.Views.StartViews;
using TourProject.Views.TouristViews;

namespace TourProject.ViewModels.TouristViewModels
{
    internal partial class TouristViewModel : ObservableObject, ITourDBContext
    {

        #region Fields

        #region Private
        private TouristView _thisView;
        private Tour _selectedTour;
        private LocationDTO_ForMap _selectedLocation_ForMap;
        private List<Location> _Locations;
        private string _selectedNameOfLocation;
        #endregion

        #region Public

        public string CredentialsProviderOfMap { get; set; }
        public TourDbContext DbContext { get; set;}
        public Tourist SelectedTourist { get; set; }
        public List<Tour> ActiveTours { get; set; }

        public Tour SelectedTour
        {
            get => _selectedTour;
            set
            {
                _selectedTour = value;
                RaisePropertyChanged();
            }
        }

        public LocationDTO_ForMap SelectedLocation_ForMap
        {
            get => _selectedLocation_ForMap;
            set
            {
                _selectedLocation_ForMap = value;
                RaisePropertyChanged();
            }
        }
        public string SelectedNameOfLocation
        {
            get => _selectedNameOfLocation;
            set
            {
                _selectedNameOfLocation = value;
                RaisePropertyChanged();
            }
        }

        public List<string> NamesOfLocations { get; set; }

        #endregion

        #endregion

        #region Commands
        public RelayCommand BackToLogin_Command { get; set; }
        public RelayCommand BuyTicket_Command { get; set; }


        #endregion

        #region Command functions
        private void BuyTicket()
        {
            Ticket ticket = GetTicket(SelectedTour);
            BuyTicketView buyTicketView = null;
            buyTicketView = new BuyTicketView(buyTicketView!, DbContext, SelectedTourist,ref ticket);
            buyTicketView.Show();
        }

        private void BackToLogin()
        {
            new LoginView().Show();
            _thisView.Close();
        }
        #endregion

        #region Other functions
        //  Get Ticket which relation with tour
        private Ticket GetTicket(Tour selectedTour)
        {
            var ticket = (from Ticket in DbContext.Tickets
                         join Tour in DbContext.Tours on Ticket.TourId equals Tour.Id
                         where Tour.Id == selectedTour.Id
                         select Ticket).FirstOrDefault();

            return ticket!;
        }

        //  Get locations which relation with SelectedTour
        private void GetLocations(Tour selectedTour)
        {
            _Locations = (from Tour in DbContext.Tours
                          join tourLocation in DbContext.TourLocations on Tour.Id equals tourLocation.TourId
                          join location in DbContext.Locations on tourLocation.TourId equals location.Id
                          where Tour.Id == selectedTour.Id
                          select location).ToList();
            GetNamesOfLocations(_Locations);
            SelectedNameOfLocation = NamesOfLocations[0];
            GetSelectedLocation_ForMap(_Locations, SelectedNameOfLocation);
        }

        private void GetNamesOfLocations(List<Location> locations)
        {
            foreach (var location in locations)
            {
                NamesOfLocations.Add(location.Name);
            }
        }

        private void GetSelectedLocation_ForMap(List<Location> locations, string name)
        {
            foreach (var location in locations)
            {
                if (location.Name == name)
                {
                    SelectedLocation_ForMap = new LocationDTO_ForMap(location.Longitude, location.Latitude);
                    return;
                }
            }
        }
        #endregion

        #region Constructor
        public TouristViewModel(TouristView thisView, ref TourDbContext dbContext, ref Tourist selectedTourist)
        {
            CredentialsProviderOfMap = MyConfigurations.CredentialsProviderOfMap;
            _thisView = thisView;
            DbContext = dbContext;
            ActiveTours = DbContext.Tours.Where(tour => tour.IsActive == true).ToList();
            SelectedTour = ActiveTours[0];
            GetLocations(SelectedTour);
            BackToLogin_Command = new RelayCommand(BackToLogin);
            BuyTicket_Command = new RelayCommand(BuyTicket);
        }
        #endregion

    }
}
