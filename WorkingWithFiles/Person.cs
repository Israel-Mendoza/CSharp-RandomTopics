using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithFiles
{
    class Person
    {
        // Fields
        private string _firstName;
        private string _lastName;
        private string _url;

        // Properties
        public string FirstName { get => this._firstName; set => this._firstName = value; }
        public string LastName { get => this._lastName; set => this._lastName = value; }
        public string URL { get => this._url; set => this._url = value; }

        // Constructor
        public Person(string firstName, string lastName, string url)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.URL = url;
        }

        // Methods
        public void DisplayPersonInfo() => Console.WriteLine($"{FirstName} {LastName}'s URL: {URL}");
    }
}
