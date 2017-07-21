using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a beverages from list \n {0} \n {1} \n {2} \n {3}"
               , "1- Hot Chocolate", "2- White Coffee with 1 sugar"
               , "3- Lemon Tea", "4- Iced Coffee");

            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    var hotChoclate = new HotChoclate();
                    hotChoclate.BoilWater();
                    Thread.Sleep(1000);
                    hotChoclate.AddDrinkingChocolateToCup();
                    Thread.Sleep(1000);
                    hotChoclate.AddWater();
                    Thread.Sleep(1000);
                    Console.ReadLine();
                    break;
                case "2":
                    var whiteCoffee = new WhiteCoffee();
                    whiteCoffee.BoilWater();
                    Thread.Sleep(1000);
                    whiteCoffee.AddSugar();
                    Thread.Sleep(1000);
                    whiteCoffee.AddCoffeeGranulesToCup();
                    Thread.Sleep(1000);
                    whiteCoffee.AddWater();
                    Thread.Sleep(1000);
                    whiteCoffee.AddMilk();
                    Thread.Sleep(1000);
                    Console.ReadLine();
                    break;
                case "3":
                    var lemonTea = new LemonTea();
                    lemonTea.BoilWater();
                    Thread.Sleep(1000);
                    lemonTea.AddWater();
                    Thread.Sleep(1000);
                    lemonTea.SteepTeaBagInHotWater();
                    Thread.Sleep(1000);
                    lemonTea.AddLemon();
                    Thread.Sleep(1000);
                    Console.ReadLine();
                    break;
                case "4":
                    var icedCoffee = new IcedCoffee();
                    icedCoffee.CrushIce();
                    Thread.Sleep(1000);
                    icedCoffee.AddIceToBlender();
                    Thread.Sleep(1000);
                    icedCoffee.AddCoffeeSyruptoBlender();
                    Thread.Sleep(1000);
                    icedCoffee.BlendIngredients();
                    Thread.Sleep(1000);
                    icedCoffee.AddIngredients();
                    Thread.Sleep(1000);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
