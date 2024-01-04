using OffersCreator.WPF.Commands;
using OffersCreator.WPF.Services;
using OffersCreator.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OffersCreator.WPF.ViewModels
{
    public class LoginPanelViewModel:ViewModelBase
    {
        private string _username;
        public string Username 
        {
            get 
            {
                return _username;
            }
            set 
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            } 
        }

        private string _password;
        public string Password 
        {
            get 
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginPanelViewModel(AccountStore accountStore, NavigationStore navigationStore, NavigationBarViewModel navigationBarViewModel)
        {
            LoginCommand = new LoginCommand(this, accountStore, new NavigationService<HomeViewModel>(
                navigationStore, () => new HomeViewModel(accountStore, navigationStore, navigationBarViewModel)));
        }



    }
}
