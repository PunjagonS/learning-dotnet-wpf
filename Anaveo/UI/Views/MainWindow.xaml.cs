using Anaveo.Common.CustomComponents.MessageAlert;
using System;
using System.Windows;

namespace Anaveo.UI.Views
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

            Service.Show(
                this,
                "Alert",
                $"Username: {username}, Password: {password}",
                () =>
                {
                    Console.WriteLine("Button closed!");
                }
            );
        }
    }
}

