using LoginScreen.Model;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace LoginScreen.ViewModel
{
    [Preserve(AllMembers = true)]
    public class LoginViewModel : BaseViewModel
    {
        #region Privates

        private User user;

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            User = new User();
            LoginCommand = new Command(Login);
        }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Properties

        public User User
        {
            get { return user; }
            set { user = value; OnPropertyChanged(); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// This methods is invoked when login button is clicked
        /// </summary>
        /// <param name="obj"></param>
        private void Login(object obj)
        {
            if(!string.IsNullOrWhiteSpace(User.Name) && !string.IsNullOrWhiteSpace(User.Password))
            {
                //TODO make login functionalities
            }
        }

        #endregion
    }
}
