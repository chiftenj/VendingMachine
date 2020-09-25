using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;
using Vending_Machine.Models.Factory;

namespace Vending_Machine.Data
{
    class Beverages
    {
        public static Beverage[] GetBeverages()
        {
            var facotry = new BeverageFactroy();
            return new Beverage[] {
               facotry.CreateHotChocolate(),
               facotry.CreateIcedTea(),
               facotry.CreateLemonTea(),
               facotry.CreateWhiteCoffeeWith1Sugar()
            };
        }
    }
}
