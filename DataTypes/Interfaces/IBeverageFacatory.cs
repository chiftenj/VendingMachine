using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Models;

namespace Vending_Machine.DataTypes.Interfaces
{
     interface IBeverageFacatory
    {
        Beverage CreateWhiteCoffeeWith1Sugar();
        Beverage CreateHotChocolate();
        Beverage CreateLemonTea();
        Beverage CreateIcedTea();

    }
}
