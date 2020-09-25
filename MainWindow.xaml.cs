using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vending_Machine.DataTypes.Interfaces;
using Vending_Machine.Models;
using Vending_Machine.Models.Factory;
using Vending_Machine.Models.VendingMachine;
using Vending_Machine.ViewModels;

namespace Vending_Machine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            //var facotry = new CreateBeverageFactroy();
            //var beverages = new Beverage[] {

            //   facotry.CreateHotChocolate(),
            //   facotry.CreateIcedTea(),
            //   facotry.CreateLemonTea(),
            //   facotry.CreateWhiteCoffeeWith1Sugar()

            //};
            
            //var c = new VendingMachine(b);
            //var water = b.Recipe.Where(x => x.Name == "water").First();
            //var boiledWater = new BoilerPart(water.Name, water.Amount);
            

            //c.SetVendingPart(ac);
            //ac.Add(water);
            //ac.Add(water);
            //c.Action();
            //c.Add(ac);
            //c.Add(b.Recipe.Where(x => x.Name == "suger").First());
            //c.Add(b.Recipe.Where(x => x.Name == "coffe").First());
            //c.Add(boiledWater);

        }
    }
}
