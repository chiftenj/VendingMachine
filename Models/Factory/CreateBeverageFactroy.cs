using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;
using Vending_Machine.Models.Beverages;

namespace Vending_Machine.Models.Factory
{
     class BeverageFactroy : IBeverageFacatory
    {
        // RecepieJson

        public static Beverage CreateBeverage(string beverageName)
        {
            switch (beverageName)
            {
                case "Hot Chocolate":
                    return new HotChocolate(beverageName);
                case "Coffe":
                    return new WhiteCoffee(beverageName);
                case "Lemon Tea":
                    return new LemonTea(beverageName);
                case "Iced Coffee":
                    return new IcedCoffe(beverageName);
            }
            throw new ArgumentException();
        }

        public  Beverage CreateHotChocolate()
        {
            return new HotChocolate("Hot Chocolate");
        }

        public  Beverage CreateWhiteCoffeeWith1Sugar()
        {
            return new WhiteCoffee("Coffee");
        }

        public  Beverage CreateLemonTea()
        {
            return new LemonTea("Lemon Tea");
        }

        public  Beverage CreateIcedTea()
        {
            return new IcedCoffe("Iced Coffee");
        }
    }
}
