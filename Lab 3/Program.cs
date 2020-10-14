using System;
using System.Runtime.CompilerServices;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hi  {userName}!\n");

            Console.WriteLine($"{userName}, please pick a number between 1 - 100.\n");

            int userNumber = Convert.ToInt32(Console.ReadLine());


            if (userNumber > 100)
            {
                Console.WriteLine("no good.");

                return;
            }  
            else if (userNumber < 1)
            {
                Console.WriteLine();

                Console.WriteLine($"{userNumber} is invalid. Please provide a number between 1 - 100.\n");
            }
            else if (userNumber % 2 == 0 && userNumber > 60)
            {
                Console.WriteLine($"{userNumber} Even");
            }
            else if (userNumber % 2 != 0 && userNumber > 60)

            {
                Console.WriteLine($"{userNumber} Odd");
            }
            else if (userNumber % 2 == 0 && userNumber > 25)

            {
                Console.WriteLine("Even");

            }
            else if (userNumber % 2 == 0 && userNumber > 1)
            {
                Console.WriteLine("Even and less than 25");
            }
            else if (userNumber % 2 != 0)
            {
                Console.WriteLine($"{userNumber} Odd");
            }
            Console.WriteLine($"Thank you for picking a number. Good-Bye {userName}.");







        }


    }
}
