using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    //start by defining what the thing we are measuring is and what the character's case will be.
    public int intelligence = 5;

    void Greet()
    {
        //this starts the switch statement and allows for many if/ifelse statements without all the hastle.
        switch(intelligence)
        {
            case 5:
                print("Happy solstice my young apprentice. How delightful to see you on this blessed day.");
                break;
            case 4:
                print("What a fine day it is. The cloud cover is dreamy, is it not?");
                break;
            case 3:
                print("What are you up to?");
                break;
            case 2:
                print("Whoa! I didn't see you there!");
                break;
            case 1:
                print("*trip* *thunk* *sigh* I always forget about that tree root.");
                break;
            //default allows for every other variable. kind of like the else statement.
            default:
                print("Incorrect intelligence level. Stop hacking the game please.")
                break;
        }
    }
}
