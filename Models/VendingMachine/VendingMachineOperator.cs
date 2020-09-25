using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DataTypes.Interfaces;
using Vending_Machine.Models.Factory;

namespace Vending_Machine.Models.VendingMachine
{
    class VendingMachineOperator
    {
        private const int ADD_DELAY = 2;
        private const int ADD_TO_CUP_DELAY = 3;
        private const int CRUSH_ICE_DELAY = 4;
        private const int ADD_TO_BLENDER_DELAY = 3;
        private const int BLEND_DELAY = 4;
        private const int BOIL_DELAY = 5;
        private const int STEEP_DELAY =4;


        private VendingMachine _vendingMachine;
        private Beverage _beverage;
        public VendingMachineOperator(Beverage beverage)
        {
            _vendingMachine = new VendingMachine();

            _beverage = beverage;
        }

        public IEnumerable<int> Start()
        {
            if(_beverage.GetType() == typeof(Beverages.HotChocolate))
            {
                return HotChocolate();
            }
            if (_beverage.GetType() == typeof(Beverages.IcedCoffe))
            {
                return IcedCoffe();
            }
            if (_beverage.GetType() == typeof(Beverages.LemonTea))
            {
                return LemonTea();
            }
            if (_beverage.GetType() == typeof(Beverages.WhiteCoffee))
            {
                return WhiteCoffee();
            }
            throw new InvalidOperationException("There is no such Beverage!");
        }

        private IEnumerable<int> HotChocolate()
        {
            var water = _beverage.Recipe.Where(x => x.Name == "water").First();
            var boiledWater = new BoilerPart(water.Name, water.Amount);
            _vendingMachine.SetVendingPart(boiledWater);
            _vendingMachine.Action();
            yield return BOIL_DELAY;
            _vendingMachine.AddToCup(_beverage.Recipe.Where(x => x.Name == "drinking chocolate").First());
            yield return ADD_TO_CUP_DELAY;
            _vendingMachine.Add(boiledWater);
            yield return ADD_DELAY;

        }

        private IEnumerable<int> IcedCoffe()
        {
            var ice = _beverage.Recipe.Where(x => x.Name == "ice").First();
            var CrushedIce = new CrusherPart(ice.Name, ice.Amount);
            _vendingMachine.SetVendingPart(CrushedIce);
            _vendingMachine.Action();
            yield return CRUSH_ICE_DELAY;
            var blendedIngreidents = new BlenderPart();
            blendedIngreidents.Add(CrushedIce);
            yield return ADD_TO_BLENDER_DELAY;
            blendedIngreidents.Add(_beverage.Recipe.Where(x => x.Name == "coffe syrup").First());
            yield return ADD_TO_BLENDER_DELAY;
            _vendingMachine.SetVendingPart(blendedIngreidents);
            _vendingMachine.Action();
            yield return BLEND_DELAY;
            _vendingMachine.Add(blendedIngreidents);
            yield return ADD_DELAY;

        }
       
        private IEnumerable<int> LemonTea()
        {
            var water = _beverage.Recipe.Where(x => x.Name == "water").First();
            var boiledWater = new BoilerPart(water.Name, water.Amount);
            _vendingMachine.SetVendingPart(boiledWater);
            _vendingMachine.Action();
            yield return BOIL_DELAY;
            _vendingMachine.Add(boiledWater);
            yield return ADD_DELAY;
            _vendingMachine.AddToHotWater(_beverage.Recipe.Where(x => x.Name == "tea bag").First());
            yield return STEEP_DELAY;
            _vendingMachine.Add(_beverage.Recipe.Where(x => x.Name == "lemon").First());
            yield return ADD_DELAY;

        }

        private IEnumerable<int> WhiteCoffee()
        {
            var water = _beverage.Recipe.Where(x => x.Name == "water").First();
            var boiledWater = new BoilerPart(water.Name, water.Amount);
            _vendingMachine.SetVendingPart(boiledWater);
            _vendingMachine.Action();
            yield return BOIL_DELAY;

            _vendingMachine.Add(_beverage.Recipe.Where(x=>x.Name=="sugar").First());
            yield return ADD_DELAY;

            _vendingMachine.AddToCup(_beverage.Recipe.Where(x => x.Name == "coffe granules").First());
            yield return ADD_TO_CUP_DELAY;

            _vendingMachine.Add(boiledWater);
            yield return ADD_DELAY;

            _vendingMachine.Add(_beverage.Recipe.Where(x => x.Name == "milk").First());
            yield return ADD_DELAY;

        }

    }
}
