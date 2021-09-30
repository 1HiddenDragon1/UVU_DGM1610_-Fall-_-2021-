using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 100000; 
            //stores whole numbers from -2147483648 to 2147483647.
            Console.WriteLine(myNum);

            long myLongNum = 15000000000L; 
            //stores whole numbers from -9223372036854775808 to 9223372036854775807.
            //Note: L at end
            Console.WriteLine(myLongNum);

            float myFloatNum = 5.75F;
            //stores fractional numbers from 3.4e−038 to 3.4e+038.
            //Note: F at end
            Console.WriteLine(myFloatNum);
            //stores fractional numbers from 1.7e−308 to 1.7e+308.
            //Note: D at end is optional
            double myDoubleNum = 19.99D;

            float f1 = 35e3F;
            double d1 = 12E4D;
            //Note: e or E is fine
            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}