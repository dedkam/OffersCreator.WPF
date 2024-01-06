using OffersCreator.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersCreator.WPF.Stores
{
    public class AccountStore
    {
        private Account _currentAccount;
        public Account CurrentAccount 
        {
            get
            {
                return _currentAccount;
            }
            set 
            {
                _currentAccount = value;
            } 
        }

        public bool IsLoggedOut => CurrentAccount == null;
    }
}
