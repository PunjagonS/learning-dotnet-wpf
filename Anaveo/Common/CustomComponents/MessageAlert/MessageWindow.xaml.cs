using System;
using System.Windows;

namespace Anaveo.Common.CustomComponents.MessageAlert
{
    public partial class MessageWindow : Window
    {
        public MessageWindow()
        {
            InitializeComponent();
        }

        public MessageWindow(ViewModel vm) : this()
        {
            DataContext = vm;
            vm.OnRequestClose += () =>
            {
                this.Close();
            };
        }
    }
}