using Models.AssistantModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.AbstractEntities
{
    public abstract class User : Human
    {
        //  Username
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (MyRegex.CheckLettersAndNumber(value)) value = _username;
                else throw new Exception("Username  is incorrect!");
            }
        }

        //  Password
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (MyRegex.CheckLettersAndNumber(value) && value.Length == 8) value = _password;
                else throw new Exception("Password  is incorrect!");
            }
        }
    }
}
