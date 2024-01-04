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
    public class NavigationBarViewModel: ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public NavigationBarViewModel(NavigationService<HomeViewModel> homeNavigationService, NavigationService<LoginViewModel> loginNavigationService)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);

        }
    }
}
