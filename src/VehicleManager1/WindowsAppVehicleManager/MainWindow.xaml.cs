using Dstrauss.VehicleManager1;
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

namespace WindowsAppVehicleManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sdner, RoutedEventArgs e)
        {
            Vehicle myVehicle = new Vehicle
            {
                Year = int.Parse(YearTextBox.Text),
                Make = MakeTextBox.Text,
                Model = ModelTextBox.Text
            };
            OutputTextBox.Text = myVehicle.GetFullName();
        }

        private void Button_Click_1(object sdner, RoutedEventArgs e)
        {
            {
                YearTextBox.Text = "";
                MakeTextBox.Text = "";
                ModelTextBox.Text = "";
                OutputTextBox.Text = "";

            };
        }
    }
}
