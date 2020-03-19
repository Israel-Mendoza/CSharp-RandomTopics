using System;
using System.Collections.Generic;
using System.Linq;
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

            // Reading line by line to an array
            string[] textLines = File.ReadAllLines(@"C:\Users\Israel Mendoza\Documents\Israelo.txt");
            Console.WriteLine("This is the text again, read line by line: ");
            foreach (var line in textLines)
                Console.WriteLine($"\t{line}");
            Console.WriteLine();

            // Reading line by line to a List<>
            List<string> textLines2 = File.ReadAllLines(@"C:\Users\Israel Mendoza\Documents\Israelo.txt").ToList();
            Console.WriteLine("This is the text line by line again, but using a List<>: ");
            foreach (var line in textLines2)
                Console.WriteLine($"\t{line}");

        }
    }
}
