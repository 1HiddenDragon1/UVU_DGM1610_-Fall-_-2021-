using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        //float = a numeric value that is able to be a decimal (not just integer)
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff (int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        //constructors give values for "member variables". (stuff like bul and gre)
        // if you don't make values for the constructor yourself then it will automatically set values for variables.
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    //these last lines of code create an Instance (an Object in the game) of the Stuff class
    //note that myStuff and myOtherStuff are connected to the two separate "Stuff" classes
    // because they have different bracket organizations.
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    private void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
