using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // wap to check the input number is prime or not

            int k = 0;
            Console.WriteLine("Enter the number");
            int i=Convert.ToInt32(Console.ReadLine());
            for(int a=1;a<=i;a++)
            {
                if(i%a==0)
                {
                    k++;

                }
            }
            if(k==2)
            {
                Console.WriteLine("it is prime number");

            }
            else
            {
                Console.WriteLine("not prime number");
            }

        }
    }
}
