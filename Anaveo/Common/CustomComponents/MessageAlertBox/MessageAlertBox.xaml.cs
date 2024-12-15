using System;
using System.Windows;

namespace Anaveo.Common.CustomComponents.MessageAlertBox
{
    public partial class MessageAlertBox : Window
    {
        public MessageAlertBox()
        {
            InitializeComponent();
        }

        public MessageAlertBox(MessageAlertBoxViewModel vm) : this()
        {
            DataContext = vm;
            vm.OnRequestClose += () =>
            {
                this.Close();
            };
        }
    }
}
