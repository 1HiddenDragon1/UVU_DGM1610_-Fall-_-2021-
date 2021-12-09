using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public UnityEvent onZeroDataEvent;

    public float Data;

    public void UpdateValue(float amount)
    {
        Data += amount;
    }

    public void ReplaceValue(float amount)
    {
        Data = amount;
    }

    public void DisplayImage(Image img)
    {
        if (Data <= 0)
        {
            onZeroDataEvent.Invoke();
        }
        else if (Data >= 1)
        {
            Data = 1;
        }

        img.fillAmount = Data;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = Data.ToString();
    }
}
