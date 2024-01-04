using OffersCreator.WPF.Models;
using OffersCreator.WPF.Services;
using OffersCreator.WPF.Stores;
using OffersCreator.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OffersCreator.WPF.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginPanelViewModel _viewModel;
        private readonly AccountStore _accountStore;
        private readonly NavigationService<HomeViewModel> _navigationService;

        public LoginCommand(LoginPanelViewModel viewModel, AccountStore accountStore, NavigationService<HomeViewModel> navigationService)
        {
            _viewModel = viewModel;
            _accountStore = accountStore;
            _navigationService = navigationService;
            
        }

        public override void Execute(object? parameter)
        {
            Account account = new Account()
            {
                Email = $"{_viewModel.Username}test.com",
                Username = _viewModel.Username
            };

            MessageBox.Show($"Logging in {_viewModel.Username}");
            _accountStore.CurrentAccount = account;

            // Navigate to the account page
            _navigationService.Navigate();
        }
    }
}
