using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TourProject.Views.StartViews;

namespace TourProject.ViewModels.StartViewModels
{
    class RegisterViewModel
    {

        #region Fields
        private RegisterView _thisView;
        private readonly TextBox _textbox_Name;
        private readonly TextBox _textbox_Surname;
        private readonly TextBox _textbox_Phone;
        private readonly TextBox _textbox_Username;
        private readonly PasswordBox _passwordBox_Password;
        private readonly TextBox _textbox_BankName;
        private readonly TextBox _textbox_CardNumber;
        private readonly DatePicker _datePicker_ExpirationDate;
        private readonly TextBox _textbox_CVC;
        private readonly TextBox _textbox_Balance;
        #endregion

        #region Commands
        public RelayCommand Register_Command { get; set; }
        public RelayCommand BackToLogin_Command { get; set; }
        #endregion

        #region Command functions
        private void Register()
        {

        }

        private void BackToLogin()
        {

        }
        #endregion

        #region Constructor
        public RegisterViewModel
            (
            RegisterView thisView,
            ref TextBox textbox_Name,
            ref TextBox textbox_Surname,
            ref TextBox textbox_Phone,
            ref TextBox textbox_Username,
            ref PasswordBox passwordBox_Password,
            ref TextBox textbox_BankName,
            ref TextBox textbox_CardNumber,
            ref DatePicker datePicker_ExpirationDate,
            ref TextBox textbox_CVC,
            ref TextBox textbox_Balance
            )
        {
            Register_Command = new RelayCommand(Register);
            BackToLogin_Command = new RelayCommand(BackToLogin);
            _thisView = thisView;
            _textbox_Name = textbox_Name;
            _textbox_Surname = textbox_Surname;
            _textbox_Phone = textbox_Phone;
            _textbox_Username = textbox_Username;
            _passwordBox_Password = passwordBox_Password;
            _textbox_BankName = textbox_BankName;
            _textbox_CardNumber = textbox_CardNumber;
            _datePicker_ExpirationDate = datePicker_ExpirationDate;
            _textbox_CVC = textbox_CVC;
            _textbox_Balance = textbox_Balance;
        }
        #endregion

    }
}
