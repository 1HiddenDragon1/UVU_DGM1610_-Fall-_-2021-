using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++; //this increases the variable so that the while loop doesn't go forever.
            }
        }
    }
}