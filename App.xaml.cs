using OffersCreator.WPF.Services;
using OffersCreator.WPF.Stores;
using OffersCreator.WPF.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace OffersCreator.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;
        
        public App()
        {
            _accountStore = new AccountStore();
            _navigationStore = new NavigationStore();
            _navigationBarViewModel = new NavigationBarViewModel(
                CreateHomeNavigationService(),
                CreateLoginNavigationService());
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            
            _navigationStore.CurrentViewModel = new LoginViewModel(_accountStore, _navigationStore, _navigationBarViewModel);
            //NavigationService<HomeViewModel> homeNavigationService = CreateHomeNavigationService();
            //homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private NavigationService<LoginViewModel> CreateLoginNavigationService()
        {
            return new NavigationService<LoginViewModel>(
                _navigationStore, () => new LoginViewModel(_accountStore, _navigationStore, _navigationBarViewModel));
        }

        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(
                _navigationStore, () => new HomeViewModel( _navigationBarViewModel));
        }
    }

}
