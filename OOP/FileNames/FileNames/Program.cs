using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileName
{
    class File
    {
        public string TxtPath;

        public File(string txtPath)
        {
            TxtPath = txtPath;
        }
        public void ReadFile()
        {
            do
            {
                Console.WriteLine("Please provide the file name (with path):");
                TxtPath = Console.ReadLine();
                if (!System.IO.File.Exists(TxtPath))
                {
                    Console.WriteLine("File does not exist.");
                    continue;
                }
                StreamReader Sr = new StreamReader(TxtPath);
                string line;
                line = Sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = Sr.ReadLine();
                }
                Sr.Close();
                break;
            }while(true);   
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            File file = new File("");
            file.ReadFile();
        }
    }
}