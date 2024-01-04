using OffersCreator.WPF.Models;
using OffersCreator.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OffersCreator.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;
        public string Username => _accountStore.CurrentAccount?.Username;

        //private readonly NavigationStore _navigationStore;
        public ClientInfoViewModel ClientInfoViewModel { get; }
        public DeviceListViewModel DeviceListViewModel { get; }
        public NavigationBarViewModel NavigationBarViewModel { get; }

        public ICommand? GenerateOfferCreatorCommand { get; }

        public HomeViewModel( NavigationBarViewModel navigationBarViewModel)
        {
            //_accountStore = accountStore;
            //_navigationStore = navigationStore;
            DeviceListViewModel = new DeviceListViewModel();
            ClientInfoViewModel = new ClientInfoViewModel();
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
