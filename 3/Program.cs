using System;
using System.Collections.Generic;

class Choice4
{
    static void Main()
    {
        Dictionary<string, string> products = new Dictionary<string, string>();

        int numLetters;
        int numDigits;

        Console.Write("Enter the number of letters (0-26): ");
        while (!int.TryParse(Console.ReadLine(), out numLetters) || numLetters < 0 || numLetters > 26)
        {
            Console.Write("Invalid input. Enter the number of letters (0-26): ");
        }

        Console.Write("Enter the number of digits (0-10): ");
        while (!int.TryParse(Console.ReadLine(), out numDigits) || numDigits < 0 || numDigits > 10)
        {
            Console.Write("Invalid input. Enter the number of digits (0-10): ");
        }

        char letter = 'A';
        int digit = 0;

        int objectCount = 0;

        while (true)
        {
            string code = letter.ToString() + digit.ToString();
            Console.WriteLine("Enter product name or type 'Stop' to finish: ");
            string productName = Console.ReadLine();

            if (productName.ToLower() == "stop")
            {
                break;
            }

            products.Add(code, productName);
            objectCount++;

            digit++;
            if (digit > 9)
            {
                digit = 0;
                letter++;
            }
            
        }

        Console.WriteLine("Enter a product code to search (e.g., A0): ");
        string searchCode = Console.ReadLine();

        if (products.ContainsKey(searchCode))
        {
            string productName = products[searchCode];
            Console.WriteLine("Product name: " + productName);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }
}
