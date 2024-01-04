using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OffersCreator.WPF.ViewModels
{
    public class ClientInfoItemViewModel : ViewModelBase
    {
        
        public ICommand ChooseClientCommand { get;}
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ClientInfoItemViewModel(string firstName, string lastName, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }
    }
}
