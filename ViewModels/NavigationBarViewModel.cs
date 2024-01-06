using OffersCreator.WPF.Commands;
using OffersCreator.WPF.Services;
using OffersCreator.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OffersCreator.WPF.ViewModels
{
    public class NavigationBarViewModel: ViewModelBase
    {
        private readonly AccountStore _accountStore;
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public bool IsLoggedOut => _accountStore.IsLoggedOut;
        public bool IsLoggedIn => !_accountStore.IsLoggedOut;
        public string Username 
        {
            get
            {
                if (!_accountStore.IsLoggedOut)
                {
                    return _accountStore.CurrentAccount.Username;
                }
                return null;
            }
        }

        public NavigationBarViewModel(AccountStore accountStore, NavigationService<HomeViewModel> homeNavigationService, NavigationService<LoginViewModel> loginNavigationService)
        {
            _accountStore = accountStore;
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);

        }
    }
}
