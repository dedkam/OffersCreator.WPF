using OffersCreator.WPF.Services;
using OffersCreator.WPF.Stores;
using OffersCreator.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersCreator.WPF.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationStore;

        public NavigateCommand(NavigationService<TViewModel> navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.Navigate();
        }
    }
}
