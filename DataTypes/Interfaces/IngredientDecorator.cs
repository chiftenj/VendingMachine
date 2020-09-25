using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.DataTypes.Interfaces
{
    abstract class IngredientDecorator : Ingredient
    {
        public IngredientDecorator(string Name, int amount) : base(Name, amount)
        {
        }

    }
}
