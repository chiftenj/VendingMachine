using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Collections;

namespace Vending_Machine.DataTypes.Interfaces
{
    abstract class Beverage
    {
        public List<String> RecipeDetail { get; set; }

        public Recipe Recipe { get; set; }

        public String Name { get; set; }

        public String ImageAddress { get; set; }

        public Beverage(String name)
        {
           
            this.Name = name;
            RecipeDetail = new List<string>();
            SetRecipeDetials();
            SetRecipe();
        }


        public abstract void SetRecipeDetials();

        public abstract void SetRecipe();



    }
}
