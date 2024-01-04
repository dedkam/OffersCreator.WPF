using OffersCreator.WPF.Commands;
using OffersCreator.WPF.Components;
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
    public class LoginViewModel : ViewModelBase
    {
        public LoginPanelViewModel OfferCreatorLoginViewModel { get; }
     
        public LoginViewModel(AccountStore accountStore, NavigationStore navigationStore, NavigationBarViewModel navigationBarViewModel) 
        {
            OfferCreatorLoginViewModel = new LoginPanelViewModel(accountStore, navigationStore, navigationBarViewModel);
        }
    }
}
