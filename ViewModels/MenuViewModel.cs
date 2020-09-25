using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vending_Machine.Commands;
using Vending_Machine.Data;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.ViewModels
{
    class MenuViewModel : BaseViewModel
    {

        private List<Beverage> _beverageItems = Beverages.GetBeverages().ToList();

        public List<Beverage> BeverageItems
        {
            get { return _beverageItems; }
            set { _beverageItems = value; }
        }

        //public ICommand VendingMachineCommand { get; set; }




    }
}
