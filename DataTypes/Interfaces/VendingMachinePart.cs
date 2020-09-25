using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.DataTypes.Interfaces
{
    abstract class VendingMachinePart : Ingredient
    {
        public VendingMachinePart(string Name, int amount) : base(Name, amount)
        {
        }

        public abstract String Run();

    }
}
