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
        public List<Tourleader> TourleaderDTOs { get; set; }
        public List<Car> CarDTOs { get; set; }
        public List<Driver> DriverDTOs { get; set; }
        public List<Location> LocationDTOs { get; set; }

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
            

            List<TourDTO> tourDTOs= new();
            List<Tour> tours = tourDb.Tours.ToList();
            foreach (var tour in tours)
            {

                #region Find tourleader name with inner join

                var tourleaderName = (from Tour in tourDb.Tours
                                      join Tourleader in tourDb.Tourleaders on Tour.TourleaderId equals Tourleader.Id
                                      where Tour.TourleaderId == tour.TourleaderId
                                      select Tourleader.Name).ToString();

                #endregion

                #region Add number of car which relation tour

                var cars = (from Tour in tourDb.Tours
                            join carTour in tourDb.CarTours on Tour.Id equals carTour.TourId
                            join car in tourDb.Cars on carTour.CarId equals car.Id
                            where Tour.Id == tour.Id
                            select car.CarNumber).ToList();

                #endregion
                
                #region Add name of location which relation tour

                var locations = (from Tour in tourDb.Tours
                            join tourLocation in tourDb.TourLocations on Tour.Id equals tourLocation.TourId
                            join location in tourDb.Locations on tourLocation.LocationId equals location.Id
                            where Tour.Id == tour.Id
                            select location.Name).ToList();

                #endregion

                #region IDs of tckets which relation with tour

                var iDsOfTickets = (from Tour in tourDb.Tours
                                      join ticket in tourDb.Tickets on Tour.Id equals ticket.TourId
                                      where Tour.TourleaderId == tour.TourleaderId
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

        private List<TourleaderDTO> TourleaderDTOFromDB(ref TourDbContext tourDb)
        {
            List<TourleaderDTO> tourleaderDTOs= new();

            return tourleaderDTOs;
        }

        private List<CarDTO> CarDTOFromDB(ref TourDbContext tourDb)
        {
            List<CarDTO> carDTOs= new();

            return carDTOs;
        }

        private List<TourDTO> DriverDTOFromDB(ref TourDbContext tourDb)
        {
            List<TourDTO> driverDTOs= new();

            return driverDTOs;
        }

        private List<TourDTO> LocationDTOFromDB(ref TourDbContext tourDb)
        {
            List<TourDTO> locationDTOs = new();

            return locationDTOs;
        }


        #endregion

        #region Constructor
        public AdminViewModel(ref TourDbContext tourDb)
        {

        }
        #endregion

    }
}
