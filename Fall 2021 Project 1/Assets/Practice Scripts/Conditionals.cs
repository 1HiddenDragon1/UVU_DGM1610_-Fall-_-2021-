using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (17 > 15)
            {
                //if statements execute this area if the "if" condition is True.
                Console.WriteLine("17 is greater than 15");
            }

            int x = 20;
            int y = 15;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 15;
            if (time < 12)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                //else statements execute this area if the "if" condition is False.
                Console.WriteLine("Good Evening");
            }
            //output result is "Good Evening"

            int SchoolSize = 5;
            if (SchoolSize > 7)
            {
                Console.WriteLine("The school is big");
            }
            else if (SchoolSize < 3)
            {
                Console.WriteLine("The school is small");
            }
            else
            {
                Console.WriteLine("The school is quaint");
            }
        }
    }
}