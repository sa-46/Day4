using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Quiz
    {
        static void Main(string[] args)
        {
            string pin = "123456";
            Console.WriteLine("Welcome to Bank of ISS");

            int count = 0;
            string input;
            do
            {
                Console.Write("Enter your PIN:");
                input = Console.ReadLine();
                count++;

                if (input == pin)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                }
                else
                {
                    switch (count)
                    {
                        case 1:
                            Console.WriteLine("Incorrect PIN. Please try again. You have 2 more tries");
                            break;
                        case 2:
                            Console.WriteLine("Incorrect PIN. Please try again. You have 1 more tries");
                            break;
                        case 3:
                            Console.WriteLine("Too many wrong PIN entries. Your account is now locked");
                            break;
                    }
                }
            } while (pin != input && count < 3);
        }
    }
}
