using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());
            int add = firstDigit + secondDigit;
            int divide = add / thirdDigit;
            int multiply = divide * fourthDigit;
            Console.WriteLine(multiply);
        }
    }
}
