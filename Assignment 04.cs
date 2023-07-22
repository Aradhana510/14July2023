using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            // Check if the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Check if the number is even or odd using the conditional operator (ternary operator)
            string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + evenOrOdd + ".");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
