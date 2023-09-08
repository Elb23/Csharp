using BookClass;
using System;//no

namespace BookClass
{
    public class Book
    {
        public List<string> Title { get; set; }
        public List<string> NumberOfPages { get; set; }
        public List<string> PublicationYear { get; set; }

        public override string ToString()
        {
            return $"{Title}\n {NumberOfPages}\n {PublicationYear}";
        }

        public Book(List<string> title, List<string> numberOfPagesList, List<string> publicationYear)
        {
            Title = title;
            NumberOfPages = numberOfPagesList;
            PublicationYear = publicationYear;
        }

        public void WaitForUserInput()
        {
            int i = 0;
            do
            {

                Console.WriteLine("\nPlease enter your book name");
                string X = Console.ReadLine();
                Title.Add(X);

                Console.WriteLine("Please enter the number of pages");
                string pagesInput = Console.ReadLine();
                if (int.TryParse(pagesInput, out int pages))
                {
                    NumberOfPages.Add(pages.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input for number of pages. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Please enter the year of publication");
                string yearInput = Console.ReadLine();// can add pattern for year using regex
                if (int.TryParse(yearInput, out int year))
                {
                    PublicationYear.Add(year.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input for publication year. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Press any space to submit, or any key to add another book");
                char KeyEntry = Console.ReadKey().KeyChar;
                if (KeyEntry == ' ')
                {
                    break;
                }
            }
            while (true);
        }

        public void Print()
        {

            do
            {
                Console.WriteLine("What would you like to print? Choose: 1. Everything, 2. Title(s)");
                char PrintInput = Console.ReadLine()[0];
                if (PrintInput == '1')
                {
                    //Console.WriteLine(this.ToString());
                    for (int i = 0; i < Title.Count; i++)
                    {
                        Console.WriteLine($"Name: {Title[i]}\nPages:{NumberOfPages[i]}\nPublication year:{PublicationYear[i]}");
                    }
                    break;
                }
                if (PrintInput == '2')
                {
                    for (int i = 0; i < Title.Count; i++)
                    {
                        Console.WriteLine($"Name:{Title[i]}");
                    }
                    break;
                }
            } while (true);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> title = new List<string>();
        List<string> numberOfPagesList = new List<string>();
        List<string> publicationYear = new List<string>();

        // Create a Book object with empty lists
        Book userBook = new Book(title, numberOfPagesList, publicationYear);

        userBook.WaitForUserInput();
        userBook.Print();
    }
}
