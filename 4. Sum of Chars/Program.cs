using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < n; i++) 
            { 
                char character = char.Parse(Console.ReadLine());
                totalSum += character;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
