using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text;


class Program
{
    public static void StringMixer() 
    {

        Console.Write("Enter text1: ");
        string text1 = Console.ReadLine();

        Console.Write("Enter text2: ");
        string text2 = Console.ReadLine(); // used as a separator

        string concatStr = text1 + text2;
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < concatStr.Length; i++)
        {
            if (i < text1.Length)
            {
                stringBuilder.Append(concatStr[i]);
            }

            if (i < text2.Length)
            {
                stringBuilder.Append(text2[i]);
            }
        }
    

        string result = stringBuilder.ToString();

        Console.Write(result);
    }
    public static void Main(string [] args)
    {
        StringMixer();

    }
}