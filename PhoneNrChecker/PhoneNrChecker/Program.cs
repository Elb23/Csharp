using System;
using System.Text.RegularExpressions;


class Program
{
    static void CheckPhoneNumber()
    {
        do
        {

            Console.WriteLine("Please enter your phone number");
            string number = Console.ReadLine();

            string pattern = @"^\+?\d{2}\s\d{3}\s\d{3}\s\d{3}$"; // 2 digits for country code +XX YYY-YYY-YYY; for no obligatory space use @"^\+?\d{2}(\s?\d{3}){3}$";
            Regex regex = new Regex(pattern); 

            bool X = regex.IsMatch(number);

            if (X == true)
            {
                Console.WriteLine("Correct phone number");
                break;
            }
            else
            {
                Console.WriteLine("The number's format should be +XX YYY-YYY-YYY");
            }
        }
        while (true);

    }








    public static void Main(string[] args)
    {

        CheckPhoneNumber();

    }


}