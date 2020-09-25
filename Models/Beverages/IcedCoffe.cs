using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Collections;
using Vending_Machine.DataTypes.Interfaces;

namespace Vending_Machine.Models.Beverages
{
    class IcedCoffe : Beverage
    {
        public IcedCoffe(string name) : base(name)
        {
            ImageAddress = "\\Images\\iced_coffee.jpg";
        }

        public override void SetRecipe()
        {
            Recipe = new Recipe(new Ice(1), new CoffeSyrup(1));
        }

        public override void SetRecipeDetials()
        {
            RecipeDetail.Add("Crush Ice");
            RecipeDetail.Add("Add ice to blender");
            RecipeDetail.Add("Add coffee syrup to blender");
            RecipeDetail.Add("Blend ingredients");
            RecipeDetail.Add("Add ingredients");
        }
    }
}
