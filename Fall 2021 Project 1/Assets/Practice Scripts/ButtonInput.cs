using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note: GetButton is advised for unity
//(see Unity's GetButton and GetKey tutorial for details)

public class ButtonInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    void Start()
    {
        graphic.sprite = standard;
    }

    void Update()
    {
        /*Pressing a button down activates GetButtonDown and GetButton (aka held)
         * holding a button down keeps the GetButton activated
         * letting go of a button only has GetButtonUp activate
         */

        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if(down)
        {
            graphic.sprite = downgfx;
        }

        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
