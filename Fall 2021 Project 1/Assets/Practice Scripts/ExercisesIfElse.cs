using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;

            if (x > y)
            {
                Console.WriteLine("Hello World");
            }

            else if (x == y)
            {
                Console.WriteLine("There is Balance in the Force");
            }

            else
            {
                Console.WriteLine("The shrowd of the dark side has fallen.");
            }

            int z = 200;
            string result = (z < 100) ? "Not enough z money." : "Thank you for your purchase.";
            Console.WriteLine(result);
        }
    }
}