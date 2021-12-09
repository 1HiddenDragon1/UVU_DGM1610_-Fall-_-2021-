using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public UnityEvent onZeroDataEvent;

    public float data;

    public void UpdateValue(float amount)
    {
        data += amount;
    }

    public void ReplaceValue(float amount)
    {
        data = amount;
    }

    public void DisplayImage(Image img)
    {
        if (data <= 0)
        {
            onZeroDataEvent.Invoke();
        }
        else if (data >= 1)
        {
            data = 1;
        }

        img.fillAmount = data;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = data.ToString();
    }
}
