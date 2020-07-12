using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Internals;

namespace LoginScreen.ViewModel
{
    [Preserve(AllMembers = true)]
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Privates

        private bool isBusy;
        private string title;

        #endregion

        #region Properties

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }

        #endregion

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
