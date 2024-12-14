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

namespace Anaveo.CustomComponent
{
    /// <summary>
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        private readonly Action _onButtonClick;

        private CustomMessageBox(Action onButtonClick)
        {
            InitializeComponent();
            _onButtonClick = onButtonClick;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            _onButtonClick?.Invoke();
            Close();
        }

        public static void Show(Window owner, string title, string message, Action onButtonClick = null)
        {
            var messageBox = new CustomMessageBox(onButtonClick)
            {
                Owner = owner,
                Title = title
            };
            messageBox.MessageText.Text = message;
            messageBox.ShowDialog();
        }
    }
}
