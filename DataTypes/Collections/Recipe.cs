using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.DataTypes.Collections
{
    class Recipe : IEnumerable<Ingredient>
    {

        private readonly IEnumerable<Ingredient> _ingredients;

        public Recipe( params Ingredient[] ingredients)
        {
            _ingredients = ingredients;
        }

        public IEnumerator<Ingredient> GetEnumerator()
        {
            return _ingredients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
