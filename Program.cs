using System;

namespace StavyaLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1-100");

            try

            {
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a series - Even numbers or Odd numbers");
                string series = Console.ReadLine();

                if (string.Compare(series, "even", ignoreCase: true) == 0)
                {
                    Console.WriteLine($"You have selcted the Even series. The numbers between 0 and {x} are:");

                    int i = 0;
                    int even = 0;
                    do
                    {
                        even = 2 * i;
                        i++;
                        Console.WriteLine($"{even} is an even number");
                    }
                    while (even < x);
                }

                else if (string.Compare(series, "odd", ignoreCase: true) == 0)
                {
                    Console.WriteLine($"You have selcted the Odd series. The numbers between 0 and {x} are:");

                    int i = 1;
                    do
                    {
                        Console.WriteLine($"{i} is an odd number");
                        i+=2;
                    }
                    while (i <= x);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value." +
                    "\nExiting program.");
            }
        }
    }
}
