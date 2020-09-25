using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.VendingMachine
{
    class BlenderPart : VendingMachinePart
    {
        private List<String> _ingredient = new List<string>();

        public BlenderPart() : base("ingredients", 0)
        {
            
        }

        public void Add(Ingredient ingredient)
        {
            this.Amount += ingredient.Amount;
            _ingredient.Add(ingredient.Name);
        }

        public override string Run()
        {
            var tempDescription = "";
            foreach (var name in _ingredient)
            {
                tempDescription += "Add " + name + Environment.NewLine;
            }
            tempDescription += "Blend " + Name;
            return tempDescription;
        }
    }
}
