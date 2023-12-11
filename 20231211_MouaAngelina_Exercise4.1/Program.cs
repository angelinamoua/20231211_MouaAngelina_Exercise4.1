using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231211_MouaAngelina_Exercise4._1
{
    internal class Perfect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            int checkNumber = 0;
            while (checkNumber == 0)
            {
                if (userInput == 6)
                {
                    Console.WriteLine("Perfect Number");
                    Console.ReadLine();
                    checkNumber = 1;
                }
                else if (userInput == 28)
                {
                    Console.WriteLine("Perfect Number");
                    Console.ReadLine();
                    checkNumber = 1;

                }
                else if (userInput == 496)
                {
                    Console.WriteLine("Perfect Number");
                    Console.ReadLine();
                    checkNumber = 1;

                }
                else if (userInput == 8128)
                {
                    Console.WriteLine("Perfect Number");
                    Console.ReadLine();
                    checkNumber = 1;

                }
                else if (checkNumber < 1)
                {
                    Console.WriteLine("Not a perfect number.");
                    Console.ReadLine();
                }
            }
        



            
        }
    }
}

