using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
            }

            int brightness = 10;
            switch(brightness)
            {
                case 1:
                    Console.WriteLine("It seems a little dark.");
                    break;
                case 2:
                    Console.WriteLine("That seems good");
                    break;
                default:
                    Console.WriteLine("Whoa, that's too bright. I'm seeing spots.");
                    break;
            }
        }
    }
}
