using Models.AsisstantClasses;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Car : IId
    {
        #region Fields
        //  Id
        public int Id { get; init; }

        //  Brand
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                if (MyRegex.CheckLettersStartWithUppercase(value)) value = _brand;
                else throw new Exception("Brand  is incorrect!");
            }
        }

        //  Model
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (MyRegex.CheckLettersStartWithUppercase(value)) value = _model;
                else throw new Exception("Model is incorrect!");
            }
        }

        //  Year
        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (MyRegex.CheckNumber(value.ToString()) && value > 0) value = _year;
                else throw new Exception("Year is incorrect!");
            }
        }

        //  Number of Car
        private string _carNumber;
        public string CarNumber
        {
            get { return _carNumber; }
            set
            {
                if (MyRegex.CheckLettersStartWithUppercase(value)) value = _carNumber;
                else throw new Exception("Number of Car is incorrect!");
            }
        }

        //  Number of seats
        private int _seatsCount;
        public int SeatCount
        {
            get { return _seatsCount; }
            set
            {
                if (MyRegex.CheckNumber(value.ToString()) && value > 0) value = _seatsCount;
                else throw new Exception("SeatCount is incorrect!");
            }
        }

        

        #endregion

        #region Navigation properties
        public virtual Driver Driver { get; set; }
        public virtual ICollection<CarTour> CarTours { get; set; }

        #endregion
    }
}
