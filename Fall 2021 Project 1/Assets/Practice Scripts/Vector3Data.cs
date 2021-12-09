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
    public float power = 10.0f;

    //In the event that UpdateFireballSpeed is started, the current fireballSpeed will be increased according to power's set amount
    public void UpdateFireballSpeed(float power)
    {
        fireballSpeed += power;
    }

    public void ResetFireballSpeed(float power)
    {
        fireballSpeed = power;
    }


}
