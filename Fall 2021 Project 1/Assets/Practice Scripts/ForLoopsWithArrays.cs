using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            /*  statement 1 is executed once. this example sets i to 0
             *  statement 2 defines the condition for executing the code block (the condition for Console.Writeline).
             *  statement 3 is executed after every time the code block is executed.
             */
            {
                Console.WriteLine(i);
            }

            for (int j = 20; j <= 32; j = j + 2)
            {
                Console.WriteLine(j);
            }

            string[] dragons = { "Western", "Eastern", "Wyvern", "Wrym", "Great Snake" };
            foreach (string i in dragons)
            {
                Console.WriteLine(i);
            }
        }
    }
}