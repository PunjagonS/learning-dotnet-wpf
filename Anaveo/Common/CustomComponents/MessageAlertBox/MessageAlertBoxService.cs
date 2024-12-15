using System;
using System.Windows;

namespace Anaveo.Common.CustomComponents.MessageAlertBox
{
    internal class MessageAlertBoxService
    {
        public static void Show(Window owner, string title, string message, Action onButtonClick = null)
        {
            var vm = new MessageAlertBoxViewModel(onButtonClick)
            {
                Title = title,
                Message = message
            };

            var window = new MessageAlertBox(vm)
            {
                Owner = owner
            };
            window.ShowDialog();
        }
    }
}
