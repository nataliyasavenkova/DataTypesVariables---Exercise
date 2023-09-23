using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                Console.WriteLine(sum);
            
        }
    }
}
