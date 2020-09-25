using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Collections;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.Beverages
{
    class HotChocolate : Beverage
    {

        public HotChocolate(string name) : base(name)
        {
            ImageAddress = "\\Images\\hot_chocolate.jpg";
        }

        public override void SetRecipe()
        {
            Recipe = new Recipe(new Water(1), new DrinkingChocolate(1));
        }

        public override void SetRecipeDetials()
        {
            RecipeDetail.Add("Boil water");
            RecipeDetail.Add("Add Drinking Chocolate to cup");
            RecipeDetail.Add("Add water");
        }
    }
}
