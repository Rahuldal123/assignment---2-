using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_without_using_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WAP for multiplication without using mathematical operator

            Console.WriteLine("enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
           
            
           for(int i=1;i<=b;i++)
            {
                c = c + a;
               
            }
            Console.WriteLine(c);
            
            
            
              

        }
    }
}
