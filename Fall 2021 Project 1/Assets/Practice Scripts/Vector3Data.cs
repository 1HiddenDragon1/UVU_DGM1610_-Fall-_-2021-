using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public UnityEvent castSpell;
    public float fireballSpeed;

    //In the event that UpdateFireballSpeed is started, the current fireballSpeed
    //will be increased according to power's set amount
    public void UpdateFireballSpeed(float power)
    {
        fireballSpeed += power;
    }

    //this can be used after the fireball has been cast or for other reasons to reset fireballSpeed
    public void ResetFireballSpeed(float power)
    {
        fireballSpeed = power;
    }

    //if fireballSpeed is below or equal to 0 power then the fireball will not be seen.
    //if fireballSpeed is above or equal to 1 it will be fully charged and cast the spell
    public void CastFireball(Image img)
    {
        if (fireballSpeed <= 0)
        {
            fireballSpeed = 0;
        }
        else if (fireballSpeed >= 1)
        {
            castSpell.Invoke();
        }

        //img.fillAmount determines how much the fireballSpeed is seen outside of the if / else if statment
        img.fillAmount = fireballSpeed;
    }

    //amount of fireballSpeed is "powered up"
    public void DisplayFireballSpeed(Text txt)
    {
        txt.text = fireballSpeed.ToString();
    }
}
