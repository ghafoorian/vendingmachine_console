using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class WhiteCoffee: Beverages
    {
        public void AddSugar()
        {
            Console.WriteLine("Add Sugar");
        }
        public void AddCoffeeGranulesToCup()
        {
            Console.WriteLine("Add Coffee Granules To Cup");
        }

        public void AddMilk()
        {
            Console.WriteLine("Add Milk");
        }

       
    }
}
