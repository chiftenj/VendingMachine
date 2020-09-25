using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models
{
    class Sugar : Ingredient
    {
        public Sugar( int amount) : base("sugar", amount)
        {
        }
    }
}
