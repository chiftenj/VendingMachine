using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.VendingMachine
{
    class CrusherPart : VendingMachinePart
    {
        public CrusherPart(string Name, int amount) : base(Name, amount)
        {
        }

        public override string Run()
        {
            return "Crush " + Name; 
        }
    }
}
