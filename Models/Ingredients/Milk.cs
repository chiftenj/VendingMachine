using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models
{
     class Milk : Ingredient
    {
        public Milk(int amount) : base("milk", amount)
        {
        }
    }
}
