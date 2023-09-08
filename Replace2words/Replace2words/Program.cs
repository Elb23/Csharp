
using System;
using System.Text.RegularExpressions;

class Program
{
   
    public static void ReplaceWords()
    

    {
        Random random = new Random();

        string specialCharacters = "!@#$%^&*()_-+=[]{}|;:'\",.<>?"; // all random char
        int randomIndex = random.Next(0, specialCharacters.Length); // random function on length to get index
        char randomChar = specialCharacters[randomIndex];          // accessing the randomChar from the list
       
        Console.WriteLine("Random character: " + randomChar);

        Console.Write("Enter the first word:");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second word:");
        string input2 = Console.ReadLine();


        string text = $"{input1}{randomChar}{input2}";
        Console.WriteLine(text);

      
        string pattern = @"[^a-zA-Z0-9]+";   
        string[] words = Regex.Split(text, pattern);

        Array.Reverse(words);

        string Output = string.Join(randomChar, words);

        Console.Write(Output);

    }

static void Main()
{
    ReplaceWords();
}

}
