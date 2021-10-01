using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            Console.WriteLine(x + y);//8
            Console.WriteLine(x - y);//2
            Console.WriteLine(x * y);//15
            Console.WriteLine(x / y);//1 since it is based on integers it rounds to the nearest whole number
            Console.WriteLine(x % y);//2 since there is a remainder of two after 3 is taken from five in it's division.
                                     //another example would be 8 % 3 = 2 because 3 is taken from 8 twice with a remainder of 2.
            Console.WriteLine(x++);//6
            Console.WriteLine(x--);//4
        }
    }
}