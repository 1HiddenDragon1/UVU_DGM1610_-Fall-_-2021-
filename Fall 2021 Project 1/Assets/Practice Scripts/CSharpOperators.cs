using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 50;
            Console.WriteLine(x);

            int sum1 = 100 + 50; //150
            int sum2 = sum1 + 250; //400
            int sum3 = sum2 + sum2; //800
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}