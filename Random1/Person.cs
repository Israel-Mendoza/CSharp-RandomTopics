using System;
using System.Collections.Generic;
using System.Text;

namespace Random1
{
    class Person
    {
        // Fields
        protected string _firstName;
        protected string _lastName;
        protected int _age;
        protected decimal _salary;
        protected string _personalMessage;
        protected string[] words;

        // Constructor
        public Person(string firstName, string lastName, int age = 18, int salary = 12_000, string personalMessage = "I am a very good person")
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this._salary = salary;
            PersonalMessage = personalMessage;
            words = PersonalMessage.Split();
        }

        // Properties
        public string FirstName
        {
            get => this._firstName;
            set => this._firstName = value;
        }
        public string LastName
        {
            get => this._lastName;
            set => this._lastName = value;
        }
        public int Age
        {
            get => this._age;
            set
            {
                if (value > 0 && value < 121)
                {
                    this._age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be a positive number between 0 and 120");
                }
            }
        }
        public decimal Salary { get; }
        public string PersonalMessage
        {
            get => this._personalMessage;
            set => this._personalMessage = value ?? "I am a very good person";
        }
        
        // Methods
        public decimal Foo(decimal multiplier) => Salary * multiplier;
        public int Foo(int multiplier) => Age * multiplier;
        
        // Deconstructor
        public void Deconstruct(out int age, out decimal salary)
        {
            age = Age;
            salary = Salary;
        }
        
        // Indexer
        public string this[int desiredIndex]
        {
            get => words[desiredIndex];
            set
            {
                if (value is string && !String.IsNullOrEmpty(value))
                {
                    words[desiredIndex] = value;
                }
                else
                {
                    throw new FormatException("Item assigment for Person object must be a non-empty string...");
                }
            }
        }
    }
}
