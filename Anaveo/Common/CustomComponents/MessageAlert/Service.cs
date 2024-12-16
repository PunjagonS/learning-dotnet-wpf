using System;
using System.Windows;

namespace Anaveo.Common.CustomComponents.MessageAlert
{
    static class Service
    {
        internal static void Show(Window owner, string title, string message, Action onButtonClick = null)
        {
            var vm = new ViewModel(onButtonClick)
            {
                Title = title,
                Message = message
            };

            var window = new MessageWindow(vm)
            {
                Owner = owner
            };
            window.ShowDialog();
        }
    }
}
