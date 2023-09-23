using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double volume = Math.PI * kegRadius * kegRadius * kegHeight;
                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = kegModel;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
