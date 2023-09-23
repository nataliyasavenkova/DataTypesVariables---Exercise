using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            for (int i = 0; i < n; i++) 
            {
                int liters = int.Parse(Console.ReadLine());
                water += liters;
                if (water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    water -= liters;
                }
            }
            Console.WriteLine($"{water}"); 
        }
    }
}
