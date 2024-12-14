using Anaveo.CustomComponents.ViewModels;
using System;
using System.Windows;

namespace Anaveo.CustomComponents.Views
{
    public partial class CustomMessageBoxView : Window
    {
        public CustomMessageBoxView()
        {
            InitializeComponent();
        }

        public CustomMessageBoxView(CustomMessageBoxViewModel vm) : this()
        {
            DataContext = vm;
            vm.OnRequestClose += () =>
            {
                this.Close();
            };
        }
    }
}
