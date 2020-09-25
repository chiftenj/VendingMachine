using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.VendingMachine
{
    class BoilerPart : VendingMachinePart 
    {
        public BoilerPart(string Name, int amount) : base(Name, amount)
        {
        }

        public override string Run()
        {
            return "Boil " + Name;
        }
    }
}
