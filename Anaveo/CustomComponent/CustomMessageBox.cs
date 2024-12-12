using System.Windows.Controls;
using System.Windows;
using System;

namespace Anaveo.CustomComponent
{
    public class CustomMessageBox
    {
        public static void Show(Window owner, string title, string message, Action onButtonClick = null)
        {
            Window messageBox = new Window
            {
                Owner = owner,
                Title = title,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                ResizeMode = ResizeMode.NoResize
            };

            StackPanel stackPanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(20)
            };

            TextBlock messageText = new TextBlock
            {
                Text = message,
                TextAlignment = TextAlignment.Center,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(messageText);

            Button closeButton = new Button
            {
                Content = "Close",
                Width = 80,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            closeButton.Click += (s, args) =>
            {
                onButtonClick?.Invoke();
                messageBox.Close();
            };
            stackPanel.Children.Add(closeButton);

            messageBox.Content = stackPanel;
            messageBox.ShowDialog();
        }
    }
}