using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x > 3 && x < 10);//returns true since both statements are true
            Console.WriteLine(x > 3 || x < 4);//returns true since at least one statement is true
            Console.WriteLine(!(x > 3 && x < 10));//returns false since both statements are true.
                                                  //Note: ! is used to reverse the result.
        }
    }
}