using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP to check given number is palindrome or not

            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int temp = num;
            while(num != 0)
            {
               int rem = num %10;
                result = result *10+ rem;

                num = num / 10;
               
            }
            num = temp;
            if (result == num)
            {
                Console.WriteLine("it is palindrome number");

            }
            else
            {
                Console.WriteLine("not palindrome number");
            }



        }
    }
}
