using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Collections;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.Beverages
{
    class WhiteCoffee : Beverage
    {
        public WhiteCoffee(string name) : base(name)
        {
            ImageAddress = "\\Images\\white_coffee.jpg";
        }

        public override void SetRecipe()
        {
            Recipe = new Recipe(new Water(1), new Sugar(1), new CoffeGranules(1), new Milk(1));
        }

        public override void SetRecipeDetials()
        {
            RecipeDetail.Add("Boil water");
            RecipeDetail.Add("Add sugar");
            RecipeDetail.Add("Add coffee granules to cup");
            RecipeDetail.Add("Add water");
            RecipeDetail.Add("Add milk");
        }
    }
}
