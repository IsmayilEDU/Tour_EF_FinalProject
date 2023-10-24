using Models.AsisstantClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.AbstractClasses
{
    public abstract class Human
    {
        //  Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (MyRegex.CheckLettersStartWithUppercase(value)) value = _name;
                else throw new Exception("Name  is incorrect!");
            }
        }

        //  Surname
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (MyRegex.CheckLettersStartWithUppercase(value)) value = _surname;
                else throw new Exception("Surname  is incorrect!");
            }
        }

        //  Phone
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (MyRegex.CheckPhone(value)) value = _phone;
                else throw new Exception("Phone  is incorrect!");
            }
        }
    }
}
