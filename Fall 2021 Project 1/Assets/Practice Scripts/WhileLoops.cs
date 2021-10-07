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

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
            //do/while loops always are executed once before they are checked to see if the conditions are met. The loop can end or continue based on the while at the end.
        }
    }
}