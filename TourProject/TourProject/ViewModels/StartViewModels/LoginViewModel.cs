﻿using Databases.Contexts;
using Models.Entities.DerivedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using TourProject.Views.StartViews;
using TourProject.Views.AdminViews;
using AppSettings;

namespace TourProject.ViewModels.StartViewModels
{
    class LoginViewModel
    {

        #region Fields
        private LoginView _thisView;
        private readonly TextBox _textbox_Username;
        private readonly PasswordBox _passwordBox_Password;
        private readonly RadioButton _radiobutton_Admin;
        private readonly RadioButton _radiobutton_Tourist;
        public TourDbContext DbContext { get; set; }
        #endregion

        #region Commands
        public RelayCommand SignIn_Command { get; set; }
        public RelayCommand Register_Command { get; set; }
        #endregion

        #region Command functions
        private void SignIn()
        {
            try
            {
                //  If user want to sign in like admin

                if (_radiobutton_Admin.IsChecked == true)
                {
                    if (CheckAdmin(in _textbox_Username, in _passwordBox_Password))
                    {
                        new AdminView().Show();
                        _thisView.Close();
                    }
                    else
                    {
                        throw new Exception("Username or password of admin incorrect!");
                    }
                }

                //  If user want to sign in like tourist
                else if (_radiobutton_Tourist.IsChecked == true)
                {

                    Tourist SelectedTourist;
                    List<Tourist> tourists = DbContext.Tourists.ToList();
                    foreach (var tourist in tourists)
                    {

                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register()
        {
            new RegisterView().Show();
            _thisView.Close();
        }
        #endregion

        #region Other functions
        private bool CheckAdmin(in TextBox textbox_Username, in PasswordBox _passwordBox_Password)
        {
            return textbox_Username.Text == MyConfigurations.UsernameOfAdmin
                                            &&
                                            _passwordBox_Password.Password == MyConfigurations.PasswordOfAdmin;
        }

        #endregion

        #region Constructor
        public LoginViewModel
                (
                    LoginView thisView,
                    ref TextBox textbox_Username, ref PasswordBox passwordBox_Password,
                    ref RadioButton radiobutton_Admin, ref RadioButton radiobutton_Tourist
                )
        {
            SignIn_Command = new RelayCommand(SignIn);
            Register_Command = new RelayCommand(Register);
            _thisView = thisView;
            _textbox_Username = textbox_Username;
            _passwordBox_Password = passwordBox_Password;
            _radiobutton_Admin = radiobutton_Admin;
            _radiobutton_Tourist = radiobutton_Tourist;
            DbContext = new();
        }
        #endregion

    }
}
