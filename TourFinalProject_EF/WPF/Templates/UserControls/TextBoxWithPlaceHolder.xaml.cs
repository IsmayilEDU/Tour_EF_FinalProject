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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Templates.UserControls
{
    /// <summary>
    /// Interaction logic for TextBoxWithPlaceHolder.xaml
    /// </summary>
    public partial class TextBoxWithPlaceHolder : UserControl
    {

        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(TextBoxWithPlaceHolder));





        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxWithPlaceHolder));






        public bool Accest
        {
            get { return (bool)GetValue(AccestProperty); }
            set { SetValue(AccestProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Accest.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AccestProperty =
            DependencyProperty.Register("Accest", typeof(bool), typeof(TextBoxWithPlaceHolder));



        public TextBoxWithPlaceHolder()
        {
            InitializeComponent();
        }
    }
}
