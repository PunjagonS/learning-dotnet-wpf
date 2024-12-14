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
using Anaveo.CustomComponents;
using Anaveo.CustomComponents.Services;

namespace Anaveo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get value username and password
            string username = Username.Text;
            string password = Password.Password;

            CustomMessageBoxService.Show(
                this,
                "Alert",
                $"Username: {username}, Password: {password}",
                () => {
                    Console.WriteLine("Button closed!");
                }
            );
        }
    }
}

