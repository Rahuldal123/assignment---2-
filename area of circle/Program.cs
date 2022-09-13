using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WAP to find the area of circle
            int i;
            Console.WriteLine("enter radius");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"area is {3.14*a*a}");

        }
    }
}
