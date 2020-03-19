using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // READING FROM FILE AND CREATING PERSON OBJECTS
            
            string filePath = @"C:\Users\Israel Mendoza\Documents\C#\RandomTests\WorkingWithFiles\PersonsFile.txt";

            List<string> myLines = File.ReadAllLines(filePath).ToList();
            List<Person> myPeople = new List<Person>();

            foreach (var line in myLines)
            {
                List<string> personString = line.Split(" - ").ToList();
                myPeople.Add(new Person(personString[0], personString[1], personString[2]));
            }

            foreach (var person in myPeople)
                person.DisplayPersonInfo();


            // WRITING TO A FILE BASED ON EXISTENT OBJECTS

            string filePath2 = @"C:\Users\Israel Mendoza\Documents\C#\RandomTests\WorkingWithFiles\PersonsFile2.txt";

            List<Person> myPeople2 = new List<Person>() { 
                new Person("Arturo", "Tadeo", "youtube.com/VladTepes"),
                new Person("Edith", "Mendoza", "estudidacta.com"),
                new Person("Israel", "Perez", "hellomundo.org")
            };

            List<string> myLines2 = new List<string>();
            foreach (var p in myPeople2)
            {
                myLines2.Add($"{p.FirstName} - {p.LastName} - {p.URL}");
            }

            File.WriteAllLines(filePath2, myLines2.ToArray());


            // WRITING TO A FILE BASED ON EXISTENT OBJECTS - Second example (from objects created in the reading file example)

            string filePath3 = @"C:\Users\Israel Mendoza\Documents\C#\RandomTests\WorkingWithFiles\PersonsFile3.txt";

            List<Person> myPeople3 = new List<Person>(myPeople);

            List<string> myLines3 = new List<string>();

            foreach (var p in myPeople3)
                myLines3.Add($"{p.FirstName} - {p.LastName} - {p.URL}");

            File.WriteAllLines(filePath3, myLines3.ToArray());


            // WRITING TO A FILE BASED ON EXISTENT OBJECTS - Third example (using StreamWriter)

            string filePath4 = @"C:\Users\Israel Mendoza\Documents\C#\RandomTests\WorkingWithFiles\PersonsFile4.txt";

            using (StreamWriter writerObj = new StreamWriter(filePath4))
            {
                foreach (var p in myPeople3)
                    writerObj.WriteLine($"{p.FirstName} - {p.LastName} - {p.URL}");
            }
        }
    }
}
