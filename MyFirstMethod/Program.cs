using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                CountTo10();
                Console.WriteLine("\n");
            }
                

            Console.ReadLine();
        }
        static void CountTo10()
        {
            for(int i = 1; i <=10; i++)
            {
                Console.Write(i);
            }
        }
    }
}
