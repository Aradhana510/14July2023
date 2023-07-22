using System;

class Program
{
    static void Main()
    {
        const string correctUsername = "john";
        const string correctPassword = "pass123";
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful.");
                break;
            }
            else if (username == correctUsername)
            {
                Console.WriteLine("Invalid password.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }

            attempts--;
        }

        if (attempts == 0)
        {
            Console.WriteLine("Login failed.");
        }
    }
}
