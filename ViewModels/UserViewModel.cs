using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Commands;
using Vending_Machine.Data;
using Vending_Machine.Models;

namespace Vending_Machine.ViewModels
{
    class UserViewModel : BaseViewModel
    {
        private User _user;

        public String FullName
        {
            get { return _user.FullUsername; }

            set
            {
                if(_user?.FullUsername != null)
                {
                    _user.FullUsername = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public String Avatar
        {
            get { return _user.Avatar; }

            set
            {
                if (_user?.Avatar != null)
                {
                  
                    _user.Avatar = value;
                    OnPropertyChanged("Avatar");
                }
            }
        }
        public RelayCommand<object> GetMenuCommand { get; set; }


        public UserViewModel()
        {
            _user = Users.GetUser();

            GetMenuCommand = new RelayCommand<object>(x =>
            {
                FullName = "ewfawef";
            });


        }
    }
}
