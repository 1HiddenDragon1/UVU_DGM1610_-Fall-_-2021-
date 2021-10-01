using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;//x=5 specifies what x is initially
            Console.WriteLine(x);
            x += 3;//x=x+3=8
            Console.WriteLine(x);
            x -= 3;//x=x-3=5
            Console.WriteLine(x);
            x *= 3;//x=x*3=15
            Console.WriteLine(x);
            x /= 3;//x=x/3=5
            Console.WriteLine(x);
            x %= 3;//x=x%3=2
            Console.WriteLine(x);
            x &= 3;//x=x&3=2 need more info
            Console.WriteLine(x);
            x |= 3;//x=x|3=3 need more info
            Console.WriteLine(x);
            x ^= 3;//x=x^3=0 need more info
            Console.WriteLine(x);
            x >>= 3;//x=x>>3=3=0 need more info
            Console.WriteLine(x);
            x <<= 3;//x=x<<3=0 need more info
            Console.WriteLine(x);
        }
    }
}