using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class HeavyWeightWorker
    {
        public void HeavyWeightWork()
        {
            /*HeavyWeightWork code is an emulator which I am using to emulate
             *some huge processing or some huge job.
             *Let us imagine that this is a library
             *that does some heavy data crunching OR some
             *extremely complex data access job etc..       
            */

            //Let us imagine Console.WriteLine() as a function that does some heavy work
            Console.WriteLine("Heavy Weight WORK Step 1 in progress...");

            //After each step this library tries to LOG.
            LogMessage("Heavy Weight WORK Log", "Step 1");

            Console.WriteLine("Heavy Weight WORK Step 2 in progress...");
            
            //After each step this library tries to LOG.
            LogMessage("Heavy Weight WORK Log ", "Step 2");

            Console.WriteLine("Heavy Weight WORK Step 3 in progress...");

            //After each step this library tries to LOG.
            LogMessage("Heavy Weight WORK Log ", "Step 3");
        }

        private static void LogMessage(string firstParam, string secondParam)
        {
            /*
             *This logger has '=' used as a decorator
             *In real scenarios the logger may be very complex.
             *Let us assume this is an HTML logger
            */
            Console.WriteLine("\n<p>=============================</p>");
            Console.WriteLine($"<strong>{firstParam} - {secondParam}\tStep completed!</strong>");
            Console.WriteLine("<p>=============================</p>\n");
        }
    }
}
