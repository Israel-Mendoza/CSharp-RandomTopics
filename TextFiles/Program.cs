using System;
using System.IO;

namespace ReadingFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Reading the whole text
            string text = File.ReadAllText(@"C:\Users\Israel Mendoza\Documents\Israelo.txt");
            Console.WriteLine("This is the text, read as a single string: ");
            Console.WriteLine(text);
            Console.WriteLine();

            // Reading line by line
            string[] textLines = File.ReadAllLines(@"C:\Users\Israel Mendoza\Documents\Israelo.txt");
            Console.WriteLine("This is the text again, read line by line: ");
            foreach (var line in textLines)
                Console.WriteLine($"\t{line}");

        }
    }
}
