using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            Console.WriteLine(x == y);//returns false due to x and y not being equal
            Console.WriteLine(x != y);//returns true because x and y are not equal
            Console.WriteLine(x > y);//returns true because x is greater than y
            Console.WriteLine(x < y);//returns false because x is not less than y
            Console.WriteLine(x >= y);//returns true because x is greater than or equal to y
            Console.WriteLine(x < y);//returns false because x is not less than or equal to y
        }
    }
}