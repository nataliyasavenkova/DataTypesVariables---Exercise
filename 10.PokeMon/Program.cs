using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int targets = 0;
            double fiftyPercentOfn = n * 0.5;
            while (n >= m)
            {
                targets++;
                n -= m;
                if ( n == (int)fiftyPercentOfn && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine($"{n}");
            Console.WriteLine($"{targets}");
        }
    }
}
