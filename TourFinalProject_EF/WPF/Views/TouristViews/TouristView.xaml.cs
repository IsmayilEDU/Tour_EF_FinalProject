using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF.Views.AdminViews.Windows
{
    /// <summary>
    /// Interaction logic for TouristView.xaml
    /// </summary>
    public partial class TouristView : Window
    {
        public ObservableCollection<Person> Persons { get; set; }
        public TouristView()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>()
            {
                new Person() {Name = "Ismayil", Surname = "Kerimzade"},
                new Person() {Name = "Huseyn", Surname = "Kerimov"},
            };
            DataContext= this;
        }
    }
}
