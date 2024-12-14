using Anaveo.CustomComponents.ViewModels;
using Anaveo.CustomComponents.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Anaveo.CustomComponents.Services
{
    internal class CustomMessageBoxService
    {
        public static void Show(Window owner, string title, string message, Action onButtonClick = null)
        {
            var vm = new CustomMessageBoxViewModel(onButtonClick)
            {
                Title = title,
                Message = message
            };

            var window = new CustomMessageBoxView(vm)
            {
                Owner = owner
            };
            window.ShowDialog();
        }
    }
}
