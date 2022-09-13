using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP for armstrong number

            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int temp = num;

            while(num!=0)
            {
                int rem = num % 10;
                int cube = rem * rem * rem;
                result=result + cube;
                num = num / 10;


            }
            num = temp;

            if (num==result)
            {
                Console.WriteLine("it is armstrong number");
            }
            else
            {
                Console.WriteLine("it is not armstrong number");
            }

              



        }
    }
}
