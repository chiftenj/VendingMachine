using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Commands;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {



        private BaseViewModel _selectedViewModel = new MenuViewModel();

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        private BaseViewModel _userViewModel = new UserViewModel();

        public BaseViewModel UserViewModel
        {
            get { return _userViewModel; }
            set { _userViewModel = value; }
        }



        public RelayCommand<object> GetMenuCommand { get; set; }

        public RelayCommand<object> GetVendingMachineCommand { get; set; }



        public MainWindowViewModel()
        {
            GetVendingMachineCommand = new RelayCommand<object>(x =>
            {
                SelectedViewModel = new VendinMachineViewModel((Beverage)x);
            });

            GetMenuCommand = new RelayCommand<object>(x =>
            {
                SelectedViewModel = new MenuViewModel();
            });
        }


        
    }
}
