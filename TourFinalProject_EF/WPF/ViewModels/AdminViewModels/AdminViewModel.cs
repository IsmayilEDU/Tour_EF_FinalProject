using Database.Contexts;
using GalaSoft.MvvmLight.Command;
using Models.DTO;
using Models.Entities.DerivedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace WPF.ViewModels.AdminViewModels
{
    internal class AdminViewModel
    {
        #region Fields

        public List<TourDTO> TourDTOs { get; set; }
        public List<TouristDTO> TouristDTOs { get; set; }
        public List<TourleaderDTO> TourleaderDTOs { get; set; }
        public List<CarDTO> CarDTOs { get; set; }
        public List<DriverDTO> DriverDTOs { get; set; }
        public List<LocationDTO> LocationDTOs { get; set; }

        #endregion

        #region Commands

        public RelayCommand ExitCommand { get; set; }

        #endregion

        #region Command functions
        private void exit()
        {

        }
        #endregion

        #region DB_Functions
        private List<TourDTO> TourDTOFromDB(ref TourDbContext tourDb)
        {

            List<TourDTO> tourDTOs = new();
            List<Tour> tours = tourDb.Tours.ToList();
            foreach (var tour in tours)
            {

                #region Find tourleader name with inner join

                var tourleaderName = (from Tour in tourDb.Tours
                                      join Tourleader in tourDb.Tourleaders on Tour.TourleaderId equals Tourleader.Id
                                      where Tour.Id == tour.Id
                                      select Tourleader.Name).FirstOrDefault();

                #endregion

                #region Add number of car which relation tour

                var numbersOfCars = (from Tour in tourDb.Tours
                                     join carTour in tourDb.CarTours on Tour.Id equals carTour.TourId
                                     join car in tourDb.Cars on carTour.CarId equals car.Id
                                     where Tour.Id == tour.Id
                                     select car.CarNumber).ToList();

                #endregion

                #region Add name of location which relation tour

                var namesOfLocations = (from Tour in tourDb.Tours
                                        join tourLocation in tourDb.TourLocations on Tour.Id equals tourLocation.TourId
                                        join location in tourDb.Locations on tourLocation.LocationId equals location.Id
                                        where Tour.Id == tour.Id
                                        select location.Name).ToList();

                #endregion

                #region IDs of tckets which relation with tour

                var iDsOfTickets = (from Tour in tourDb.Tours
                                    join ticket in tourDb.Tickets on Tour.Id equals ticket.TourId
                                    where Tour.Id == tour.Id
                                    select ticket.Id).ToList();
                #endregion

                #region Create tourDTO

                var tourDTO = new TourDTO
                {
                    Id = tour.Id,
                    StartTime = DateOnly.FromDateTime(tour.StartTime),
                    FinishTime = DateOnly.FromDateTime(tour.FinishTime),
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

        private List<TouristDTO> TouristDTOFromDB(ref TourDbContext tourDb)
        {

            List<TouristDTO> touristDTOs = new();
            List<Tourist> tourists = tourDb.Tourists.ToList();
            foreach (var tourist in tourists)
            {

                #region Find balance of bankcard whiceh relation with tourist

                var balanceOfBankcard = (from Tourist in tourDb.Tourists
                                         join Bankcard in tourDb.BankCards on Tourist.Id equals Bankcard.TouristId
                                         where Tourist.Id == tourist.Id
                                         select Bankcard.Balance).FirstOrDefault();

                #endregion

                #region IDs of tickets which relation with tourist

                var iDsOfTickets = (from Tourist in tourDb.Tourists
                                    join ticket in tourDb.Tickets on Tourist.Id equals ticket.TouristId
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

        private List<TourleaderDTO> TourleaderDTOFromDB(ref TourDbContext tourDb)
        {
            List<TourleaderDTO> tourleaderDTOs = new();
            List<Tourleader> tourleaders = tourDb.Tourleaders.ToList();

            foreach (var tourleader in tourleaders)
            {
                var iDsOfTours = (from Tourleader in tourDb.Tourleaders
                                  join Tour in tourDb.Tours on tourleader.Id equals Tour.TourleaderId
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

        private List<CarDTO> CarDTOFromDB(ref TourDbContext tourDb)
        {
            List<CarDTO> carDTOs = new();
            List<Car> cars = tourDb.Cars.ToList();

            foreach (var car in cars)
            {
                var driverName = (from Car in tourDb.Cars
                                  join Driver in tourDb.Drivers on Car.Id equals Driver.CarId
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

        private List<DriverDTO> DriverDTOFromDB(ref TourDbContext tourDb)
        {
            List<DriverDTO> driverDTOs = new();
            List<Driver> drivers = tourDb.Drivers.ToList();

            foreach (var driver in drivers)
            {
                var carNumber = (from Car in tourDb.Cars
                                  join Driver in tourDb.Drivers on Car.Id equals Driver.CarId
                                  where driver.Id == Driver.Id
                                  select Car.CarNumber).FirstOrDefault();

                var driverDTO = new DriverDTO()
                {
                    Id = driver.Id,
                    Name= driver.Name,
                    Surname= driver.Surname,
                    Phone= driver.Phone,
                    driverLicenseCategory = driver.driverLicenseCategory,
                    CarNumber= carNumber!,
                    
                };
            }
            return driverDTOs;
        }

        private List<LocationDTO> LocationDTOFromDB(ref TourDbContext tourDb)
        {
            List<LocationDTO> locationDTOs = new();
            List<Location> locations= tourDb.Locations.ToList();

            foreach (var location in locations)
            {
                var iDsOfTours = (from Tour in tourDb.Tours
                                     join tourLocation in tourDb.TourLocations on Tour.Id equals tourLocation.TourId
                                     join Location in tourDb.Locations on tourLocation.LocationId equals Location.Id
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
        public AdminViewModel(ref TourDbContext tourDb)
        {
            TourDTOs = TourDTOFromDB(ref tourDb);
            TouristDTOs = TouristDTOFromDB(ref tourDb);
            TourleaderDTOs = TourleaderDTOFromDB(ref tourDb);
            CarDTOs = CarDTOFromDB(ref tourDb);
            DriverDTOs = DriverDTOFromDB(ref tourDb);
            LocationDTOs = LocationDTOFromDB(ref tourDb);
        }
        #endregion

    }
}
