using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// The Program starts here in the main function.
        /// it calls 2 other functions 
        /// CountTo10 and CountToN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n1 = 20;
            int n2 = 30;
            CountTo10();
            Console.WriteLine("\n");
            CountToN(n1, n2);
            

            Console.ReadLine();
        }
        /// <summary>
        /// It creates another var called "n" and sends it to the function CountToN to be printed.
        /// 
        /// </summary>
        static void CountTo10()
        {
            int n1 = 10;
            int n2 = 20;
            CountToN(n1, n2);
        }
        /// <summary>
        /// Counts to any number given in the main function.
        /// </summary>
        /// 
        /// <param name="n">
        /// The parameter "n" is an integer specefied and given by the main function
        /// 
        /// </param>
        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.Write(" {0}",i);
            }
        }
    }
}
