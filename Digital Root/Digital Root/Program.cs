using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void DigitalRoot()
    {
        do
        {
            Console.WriteLine("Please enter a positive number:");
            string X = Console.ReadLine();

            if (int.TryParse(X, out int userInput) && userInput > 0)
            {
                Console.WriteLine($"The Digital Root of {userInput} is: ");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }


            bool cdt = true;

            while (cdt == true)
            {
                List<int> digitList = userInput.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
                int sum = 0;
                foreach (int digit in digitList)
                {
                    sum += digit;
                    userInput = sum;
                }
                if (userInput < 10)
                {
                    Console.WriteLine(userInput);
                    cdt = false;
                }
            }
        }
        while (true);
    }
    static void Main(string[] args) 
    {

        DigitalRoot();
    }
}


