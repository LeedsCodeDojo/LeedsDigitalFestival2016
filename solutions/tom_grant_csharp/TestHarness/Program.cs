using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistanceLib;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter string 1:");
                var s1 = Console.ReadLine().Trim();

                Console.WriteLine("Enter string 2:");
                var s2 = Console.ReadLine().Trim();

                Console.WriteLine(new Calculator().distance(s1, s2));
            }
        }
    }
}
