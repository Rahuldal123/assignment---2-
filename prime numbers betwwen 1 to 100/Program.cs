using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers_betwwen_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WAP to find prime numbers from 1 to 100
            
            for (int i = 2; i <= 100; i++)
            {
                int k = 0;
                for (int j = 2; j <= 100; j++)
                {
                    if (i!=j && i % j  == 0)
                    {
                        k++;
                        break;
                    }
                
                    
                    
                        
                    
                }
                if (k == 0)
                {
                    Console.WriteLine(i);

                }
            }
                    


            
        }
    }
}
