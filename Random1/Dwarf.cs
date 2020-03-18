using System;
using System.Collections.Generic;
using System.Text;

namespace Random1
{

    class Dwarf : Person
    {
        private int _beardLength;


        public Dwarf(string firstName, string lastName, int beardLength, int age = 18, int salary = 25_000, string personalMessage = "Hop ahop, I love my gold!")
            : base(firstName, lastName, age, salary, personalMessage)
        {
            BeardLength = beardLength;
        }

        public int BeardLength { get => _beardLength; set => _beardLength = value; }
    }
}
