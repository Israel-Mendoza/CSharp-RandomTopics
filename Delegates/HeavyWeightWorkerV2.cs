using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void Logger(string firstParam, string secondParam);

    class HeavyWeightWorkerV2
    {
        public Logger ConsumerLoggerHook;
        
        public void HeavyWeightWork()
        {
            /*After each step this library tries to LOG. But NOTE that this library
             *has no LOGGER implemented. Instead, this library has judiciously DELEGATED
             *the logging responsibility to the CONSUMER of this library.
            */
            Console.WriteLine("Heavy Weight WORK Step 1");
            
            /*After each step this library tries to LOG.*/
            ConsumerLoggerHook("Heavy Weight WORK Log ", "Step 1");

            Console.WriteLine("Heavy Weight WORK Step 2");
           
            /*After each step this library tries to LOG.*/
            ConsumerLoggerHook("Heavy Weight WORK Log ", "Step 2");

            Console.WriteLine("Heavy Weight WORK Step 3");
           
            /*After each step this library tries to LOG.*/
            ConsumerLoggerHook("Heavy Weight WORK Log ", "Step 3");
        }
    }
}
