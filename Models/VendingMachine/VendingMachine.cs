using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;


namespace Vending_Machine.Models.VendingMachine
{
    class VendingMachine
    {
        private VendingMachinePart _vendingPart;
        // private Boiler _boiler;
        // Private Blender _blender;
        // private Crusher _crusher;
        public VendingMachine()
        {
        }

        public void SetVendingPart(VendingMachinePart vendingPart)
        {
            _vendingPart = vendingPart;
        }

        public String Add(Ingredient ingredient)
        {
            return "Add " + ingredient.Name;
        }
        public String AddToCup(Ingredient ingredient)
        {
            return "Add " + ingredient.Name;
        }
        public String AddToHotWater(Ingredient ingredient)
        {
            return "Steep " + ingredient.Name + " in hot water";
        }


        public String Action()
        {
            return _vendingPart.Run();
        }
        

    }
}
