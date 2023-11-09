using Database.Contexts;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Models.Entities.DerivedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp.Views.AdminViews;
using WpfApp.Views.StartViews;

namespace WpfApp.ViewModels.AdminViewModels
{
    internal class AdminViewModel : ITourDBContext
    {

        #region Fields
        private AdminView _thisView;
        public List<TourDTO> TourDTOs { get; set; }
        public List<TouristDTO> TouristDTOs { get; set; }
        public List<TourleaderDTO> TourleaderDTOs { get; set; }
        public List<CarDTO> CarDTOs { get; set; }
        public List<DriverDTO> DriverDTOs { get; set; }
        public List<LocationDTO> LocationDTOs { get; set; }
        public TourDbContext DbContext { get ; set ; }

        #endregion

        #region Commands

        public RelayCommand Exit_Command { get; set; }

        #endregion

        #region Command functions
        private void exit()
        {
            new LoginView().Show();
            _thisView.Close();
        }
        #endregion

        #region DB_Functions
        private List<TourDTO> TourDTOFromDB()
        {

            List<TourDTO> tourDTOs = new();
            List<Tour> tours = DbContext.Tours.ToList();
            foreach (var tour in tours)
            {

                #region Find tourleader name with inner join

                var tourleaderName = (from Tour in DbContext.Tours
                                      join Tourleader in DbContext.Tourleaders on Tour.TourleaderId equals Tourleader.Id
                                      where Tour.Id == tour.Id
                                      select Tourleader.Name).FirstOrDefault();

                #endregion

                #region Add number of car which relation tour

                var numbersOfCars = (from Tour in DbContext.Tours
                                     join carTour in DbContext.CarTours on Tour.Id equals carTour.TourId
                                     join car in DbContext.Cars on carTour.CarId equals car.Id
                                     where Tour.Id == tour.Id
                                     select car.CarNumber).ToList();

                #endregion

                #region Add name of location which relation tour

                var namesOfLocations = (from Tour in DbContext.Tours
                                        join tourLocation in DbContext.TourLocations on Tour.Id equals tourLocation.TourId
                                        join location in DbContext.Locations on tourLocation.LocationId equals location.Id
                                        where Tour.Id == tour.Id
                                        select location.Name).ToList();

                #endregion

                #region IDs of tckets which relation with tour

                var iDsOfTickets = (from Tour in DbContext.Tours
                                    join ticket in DbContext.Tickets on Tour.Id equals ticket.TourId
                                    where Tour.Id == tour.Id
                                    select ticket.Id).ToList();
                #endregion

                #region Create tourDTO

                var tourDTO = new TourDTO
                {
                    Id = tour.Id,
                    StartTime = tour.StartTime,
                    FinishTime =tour.FinishTime,
                    TourleaderName = tourleaderName!,
                    IsActive = tour.IsActive,
                    NumbersOfCars = numbersOfCars,
                    NamesOfLocations = namesOfLocations,
                    IDsOfTickets = iDsOfTickets
                };

                #endregion

                tourDTOs.Add(tourDTO);
            }
            return tourDTOs;
        }

        private List<TouristDTO> TouristDTOFromDB()
        {

            List<TouristDTO> touristDTOs = new();
            List<Tourist> tourists = DbContext.Tourists.ToList();
            foreach (var tourist in tourists)
            {

                #region Find balance of bankcard whiceh relation with tourist

                var balanceOfBankcard = (from Tourist in DbContext.Tourists
                                         join Bankcard in DbContext.BankCards on Tourist.Id equals Bankcard.TouristId
                                         where Tourist.Id == tourist.Id
                                         select Bankcard.Balance).FirstOrDefault();

                #endregion

                #region IDs of tickets which relation with tourist

                var iDsOfTickets = (from Tourist in DbContext.Tourists
                                    join ticket in DbContext.Tickets on Tourist.Id equals ticket.TouristId
                                    where Tourist.Id == tourist.Id
                                    select ticket.Id).ToList();
                #endregion

                #region Create tourDTO

                var touristDTO = new TouristDTO
                {
                    Id = tourist.Id,
                    Username = tourist.Username,
                    Password = tourist.Password,
                    Name = tourist.Name,
                    Surname = tourist.Surname,
                    Phone = tourist.Phone,
                    BalanceOfBankcard = balanceOfBankcard,
                    IDsOfTickets = iDsOfTickets,
                };

                #endregion

                touristDTOs.Add(touristDTO);
            }
            return touristDTOs;
        }

        private List<TourleaderDTO> TourleaderDTOFromDB()
        {
            List<TourleaderDTO> tourleaderDTOs = new();
            List<Tourleader> tourleaders = DbContext.Tourleaders.ToList();

            foreach (var tourleader in tourleaders)
            {
                var iDsOfTours = (from Tourleader in DbContext.Tourleaders
                                  join Tour in DbContext.Tours on tourleader.Id equals Tour.TourleaderId
                                  where Tourleader.Id == tourleader.Id
                                  select Tourleader.Id).ToList();

                var tourleaderDTO = new TourleaderDTO()
                {
                    Id = tourleader.Id,
                    Name = tourleader.Name,
                    Surname = tourleader.Surname,
                    Phone = tourleader.Phone,
                    IDsOfTours = iDsOfTours
                };
            }

            return tourleaderDTOs;
        }

        private List<CarDTO> CarDTOFromDB()
        {
            List<CarDTO> carDTOs = new();
            List<Car> cars = DbContext.Cars.ToList();

            foreach (var car in cars)
            {
                var driverName = (from Car in DbContext.Cars
                                  join Driver in DbContext.Drivers on Car.Id equals Driver.CarId
                                  where car.Id == Car.Id
                                  select Driver.Name).FirstOrDefault();

                var carDTO = new CarDTO()
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    SeatCount = car.SeatCount,
                    CarNumber = car.CarNumber,
                    DriverName = driverName!
                };
            }
            return carDTOs;
        }

        private List<DriverDTO> DriverDTOFromDB()
        {
            List<DriverDTO> driverDTOs = new();
            List<Driver> drivers = DbContext.Drivers.ToList();

            foreach (var driver in drivers)
            {
                var carNumber = (from Car in DbContext.Cars
                                 join Driver in DbContext.Drivers on Car.Id equals Driver.CarId
                                 where driver.Id == Driver.Id
                                 select Car.CarNumber).FirstOrDefault();

                var driverDTO = new DriverDTO()
                {
                    Id = driver.Id,
                    Name = driver.Name,
                    Surname = driver.Surname,
                    Phone = driver.Phone,
                    driverLicenseCategory = driver.driverLicenseCategory,
                    CarNumber = carNumber!,

                };
            }
            return driverDTOs;
        }

        private List<LocationDTO> LocationDTOFromDB()
        {
            List<LocationDTO> locationDTOs = new();
            List<Location> locations = DbContext.Locations.ToList();

            foreach (var location in locations)
            {
                var iDsOfTours = (from Tour in DbContext.Tours
                                  join tourLocation in DbContext.TourLocations on Tour.Id equals tourLocation.TourId
                                  join Location in DbContext.Locations on tourLocation.LocationId equals Location.Id
                                  where location.Id == Location.Id
                                  select Tour.Id).ToList();

                var locationDTO = new LocationDTO()
                {
                    Id = location.Id,
                    Name = location.Name,
                    Longitude = location.Longitude,
                    Latitude = location.Latitude,
                    IDsOfTours = iDsOfTours
                };
                locationDTOs.Add(locationDTO);

            }
            return locationDTOs;
        }


        #endregion

        #region Constructor
        public AdminViewModel(AdminView thisView,ref TourDbContext tourDb)
        {
            Exit_Command = new RelayCommand(exit);
            _thisView= thisView;
            DbContext = tourDb;
            TourDTOs = TourDTOFromDB();
            TouristDTOs = TouristDTOFromDB();
            TourleaderDTOs = TourleaderDTOFromDB();
            CarDTOs = CarDTOFromDB();
            DriverDTOs = DriverDTOFromDB();
            LocationDTOs = LocationDTOFromDB();
        }
        #endregion

    }
}
