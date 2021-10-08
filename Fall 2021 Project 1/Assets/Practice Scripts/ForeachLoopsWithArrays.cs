using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //to declare an array, put the variable type then [] after
            string[] swords = {"Broadsword", "Katana", "Falcion", "Shortsword", "Cutlass"};
            Console.WriteLine(swords[0]);
            //output is Broadsword because arrays naturally start at 0.

            //to change an element refer to the index number
            string[] dragons = {"Fire breathing", "Aquatic", "Ice", "Earthshaking", "Skydweller"};
            dragons[2] = "Iceborn";
            Console.WriteLine(dragons[2]);
            //output is Iceborn instead of Ice because the #2 array item was changed

            /*how to determine the length of an array quickly?
             *write Console.WriteLine(dragons.Length);
             */
            Console.WriteLine(swords.Length);
            Console.WriteLine(dragons.Length);
            //output will be 5 and 5

            //putting the array through a loop. can be used to display all components of an array or specific components.
            //example shows all components of array being displayed.
            string[] TMNT = {"Leonardo", "Donatello", "Michelangelo", "Raphael"};
            for (int i = 0; i < TMNT.Length; i++)
            {
                Console.WriteLine(TMNT[i]);
            }
            //output is all four names.
            //remember correct syntax!

            //foreach code loop will send out everything in a code loop.
            //The loop is done so more quickly and easy to write out in foreach.
            string[] fightingStyle = { "Boxer", "Kickboxer", "Judo", "Karate", "CQC" };
            foreach (string i in fightingStyle)
            {
                Console.WriteLine(i);
            }
            //output is all five fightingStyles
        }
    }
}