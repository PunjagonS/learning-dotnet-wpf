using Anaveo.Common.CustomComponents.Commands;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Anaveo.Common.CustomComponents.MessageAlertBox
{
    public class MessageAlertBoxViewModel : INotifyPropertyChanged
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
        public MessageAlertBoxViewModel(Action onButtonClick = null)
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
