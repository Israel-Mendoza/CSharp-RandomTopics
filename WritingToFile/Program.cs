using System;
using System.Collections.Generic;
using System.IO;

namespace WritingToTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Creating a string array
            string[] myLines = new string[5];
            myLines[0] = "One freaking line";
            myLines[1] = "Another awsome line";
            myLines[2] = "Yet another line";
            myLines[3] = "Another one? Ok!";
            myLines[4] = "Really?";


            string[] myLines2 = new string[5];
            myLines2[0] = "Una hermosa línea";
            myLines2[1] = "Otra bella línea";
            myLines2[2] = "Oooootra línea...";
            myLines2[3] = "¿Otra? Bueeeno...";
            myLines2[4] = "¿Neta?";

            List<string> myLines3 = new List<string>();
            foreach (var line in myLines2)
                myLines3.Add(line);


            // Writing the lines to the file
            File.WriteAllLines(@"C:\Users\Israel Mendoza\Documents\IsraelByLines.txt", myLines);

            // Create a single string with the file contents
            string myText = "This is one line\nThis is another line\nYet another line\nOk... Another line...\nFor real?";

            // Write the complete string to the file
            File.WriteAllText(@"C:\Users\Israel Mendoza\Documents\IsraelByText.txt", myText);

            // Using a StreamWriter object
            // If the append argument is set to "true", the stramwriter will append to the file. The default is false.
            using (StreamWriter streamWriterObj = new StreamWriter(@"C:\Users\Israel Mendoza\Documents\UsingStreamWriter.txt"))
            {
                foreach(var line in myLines)
                {
                    if (line.ToLower().Contains("line"))
                        streamWriterObj.WriteLine(line);
                }
            }

            using (StreamWriter streamWriterObj = new StreamWriter(@"C:\Users\Israel Mendoza\Documents\UsingStreamWriter.txt", true))
            {
                foreach (var line in myLines3)
                    streamWriterObj.WriteLine(line);
            }
        }
    }
}
