using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimeter_of_reactangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP for permeter of rectangle

            Console.WriteLine("enter the length and breadth of reactange");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"perimer of reactangle is {2*(l + b)}");

        }
    }
}
