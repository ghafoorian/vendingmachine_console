using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class LemonTea: Beverages
    {
        public void SteepTeaBagInHotWater()
        {
            Console.WriteLine("Steep Tea Bag In Hot Water");
        }
        public void AddLemon()
        {
            Console.WriteLine("Add Lemon");
        }
    }
}
