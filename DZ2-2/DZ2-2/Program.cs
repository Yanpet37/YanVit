using System.Collections.Generic;

namespace DZ2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is DZ2-2");

            Console.Write("Fill in the first number: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input, you need to change.");
                Console.Write("Fill in the first number: ");
            }

            Console.Write("Fill in the second number: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input, you need to change.");
                Console.Write("Fill in the second number: ");
            }

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");

            if (num2 != 0)
            {
                Console.WriteLine($"Quotient: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Quotient: The system can not use 0.");
            }

        }
    }
}
