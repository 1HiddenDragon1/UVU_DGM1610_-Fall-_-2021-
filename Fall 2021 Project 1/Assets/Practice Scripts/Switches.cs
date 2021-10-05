using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 5;
            switch(day)
            {
                case 1: //if the integer is 1 then this case will activate.
                    Console.WriteLine("It is Monday");
                    break; //the break allows the program to stop searching if this case was the one activated.
                case 2:
                    Console.WriteLine("It is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It is Thursday");
                    break;
                case 5:
                    Console.WriteLine("It is Friday");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday");
                    break;
                //output will be Friday (day 5)
            }
        }
    }
}