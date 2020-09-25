using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.DataTypes.Interfaces
{

    abstract class Ingredient
    {
        public String Name { get; }
        public int Amount { get; set; }

        protected Ingredient(String Name, int amount)
        {
            this.Name = Name;
            this.Amount = amount;
        }

   }
}
