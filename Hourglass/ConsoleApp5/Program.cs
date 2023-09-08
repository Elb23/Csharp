using System;
class Program
{
public static void DrawHourGlass()
    {
        do
        {
            Console.Write("Hello, Please enter a number bigger than 3:");
            string userInput = Console.ReadLine();
            int height;
            if (int.TryParse(userInput, out height) && height > 3)
            {
                List<char> list = new List<char>(new string('*', height).ToCharArray()); ;
                int lastIndex = (list.Count - 1);

                bool direction = true;

                for (int i = 0; i < lastIndex / 2; i++)
                {
                    Console.WriteLine(string.Join("", list));
                    list[i] = '\u0020'; // whitespace
                    list[lastIndex - i] = list[i];
                    direction = false;

                }
                if (direction == false)
                {
                    for (int j = lastIndex / 2; j <= lastIndex; j++)
                    {
                        list[j] = '*';
                        list[lastIndex - j] = '*';
                        Console.WriteLine(string.Join("", list)); // Output: * * * * *
                    }

                }
            }
            else
            {
               
                Console.WriteLine("Invalid input. Please enter an integer greater than 3."); // Invalid input 
            }
        } while (true);
    }

static void Main()
{ 

    DrawHourGlass();

}


}