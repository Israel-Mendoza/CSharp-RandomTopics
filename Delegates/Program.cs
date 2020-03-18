using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            HeavyWeightWorkerV2 myHeavyWorker = new HeavyWeightWorkerV2();

            myHeavyWorker.ConsumerLoggerHook = StupidLogger;
            myHeavyWorker.ConsumerLoggerHook += ClientsCustomizedLoggerOne;
            
            myHeavyWorker.HeavyWeightWork();

        }

        private static void StupidLogger(string firstParam, string secondParam)
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

        // Custom consumer logger 1
        public static void ClientsCustomizedLoggerOne(string firstParam, string secondParam)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Delegated Logging IN CONSUMER code " + firstParam + " - " + secondParam);
            Console.WriteLine("=============================");
        }

        // Custom consumer logger 2
        public static void ClientsCustomizedLoggerTwo(string firstParam, string secondParam)
        {
            /*
            *This logger has '-' used as a decorator
            *Let us assume this is an XML logger
            */
            Console.WriteLine("------------------------------");
            Console.WriteLine("Delegated Logging IN CONSUMER code " + firstParam + " - " + secondParam);
            Console.WriteLine("------------------------------");
        }
    }
}
