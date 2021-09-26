using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    /*enumerations allow for words to be turned into numbers for the computer
     * in current script North = 0, East = 1, South = 2, etc.
     * I can change script to be "enum Direction {North = 1, East = 5, South = 21, West = 15}"
     * or if I change the script to be North = 5 but don't specify the rest, 
     *  then they will just add one for each enum. so East = 6 in this case.
     */
    enum Direction {North, East, South, West};

    private void Start()
    {
        Direction myDirection;
        myDirection = Direction.North;
    }

    Direction ReverseDirection (Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
