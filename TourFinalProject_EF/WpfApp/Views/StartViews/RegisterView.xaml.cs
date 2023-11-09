using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp.ViewModels.StartViewModels;

namespace WpfApp.Views.StartViews
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel
                (
                this,
                ref textbox_Name,
                ref textbox_Surname,
                ref textbox_Phone,
                ref textbox_Username,
                ref passwordBox_Password,
                ref textbox_BankName,
                ref textbox_CardNumber,
                ref datePicker_ExpirationDate,
                ref textbox_CVC,
                ref textbox_Balance
                );
        }
    }
}
