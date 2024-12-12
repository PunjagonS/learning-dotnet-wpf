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

            // Create a custom Window for the message box
            Window messageBox = new Window
            {
                Title = "Alert",
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this,
                ResizeMode = ResizeMode.NoResize // Disable resizing
            };

            // Create a StackPanel for layout
            StackPanel stackPanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(20)
            };

            // Add a TextBlock for the message
            TextBlock messageText = new TextBlock
            {
                Text = "Button clicked!",
                TextAlignment = TextAlignment.Center,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(messageText);

            // Add a Button to close the message box
            Button closeButton = new Button
            {
                Content = "Close",
                Width = 80,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            closeButton.Click += (s, args) => messageBox.Close();
            stackPanel.Children.Add(closeButton);

            // Set the content of the custom window
            messageBox.Content = stackPanel;

            // Show the custom MessageBox
            messageBox.ShowDialog();
        }
    }
}
