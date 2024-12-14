using Anaveo.CustomComponents.Commands;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Anaveo.CustomComponents.ViewModels
{
    public class CustomMessageBoxViewModel : INotifyPropertyChanged
    {

        #region Properties
        private string _title;
        public string Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(); }
        } 
        #endregion

        public ICommand CloseCommand { get; }
        private readonly Action _onButtonClick;
        public event Action OnRequestClose;
        public CustomMessageBoxViewModel(Action onButtonClick = null)
        {
            _onButtonClick = onButtonClick;

            CloseCommand = new RelayCommand(_ =>
            {
                _onButtonClick?.Invoke();
                OnRequestClose?.Invoke();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
