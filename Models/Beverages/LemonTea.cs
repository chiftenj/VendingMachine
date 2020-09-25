using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Collections;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.Beverages
{
    class LemonTea : Beverage
    {
        public LemonTea(string name) : base(name)
        {
            ImageAddress = "\\Images\\lemon_tea.jpg";
        }

        public override void SetRecipe()
        {
            Recipe = new Recipe(new Water(1), new TeaBag(1), new Lemon(1));
        }

        public override void SetRecipeDetials()
        {
            RecipeDetail.Add("Boil water");
            RecipeDetail.Add("Add water");
            RecipeDetail.Add("Steep tea bag in hot water");
            RecipeDetail.Add("Add lemon");
        }
    }
}
