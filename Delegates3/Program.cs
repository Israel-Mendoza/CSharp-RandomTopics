using System;

namespace Delegates3
{
    public delegate void SampleDelegate(out int number);
        
    class Program
    {
        static void Main(string[] args)
        {

            // Multicasting            
            SampleDelegate masterDel = SampleMethod1;
            masterDel += SampleMethod2;
            masterDel += SampleMethod3;

            int randomNumber;
            masterDel(out randomNumber);

            Console.WriteLine($"After invoking a multicasting delegate, the final result of \"randomNumber\" is {randomNumber}");

        }

        static void SampleMethod1(out int number) => number = 1;
        static void SampleMethod2(out int number) => number = 2;
        static void SampleMethod3(out int number) => number = 3;

    }
}
