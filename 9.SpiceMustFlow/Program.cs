using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpices = 0;
            while (yield >= 100)
            {
                days++;
                totalSpices += yield - 26;
                yield -= 10;
            }
            if (totalSpices >= 26)
            {
                totalSpices -= 26;
            }
            Console.WriteLine($"{days}");
            Console.WriteLine($"{totalSpices}");
        }
    }
}
