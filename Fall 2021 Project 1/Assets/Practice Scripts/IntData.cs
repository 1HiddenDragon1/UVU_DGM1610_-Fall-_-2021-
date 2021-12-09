using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int bushel;

    public void UpdateValue(int apple)
    {
        bushel += apple;
    }

    public void ReplaceValue(int apple)
    {
        bushel = apple;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = bushel;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = bushel.ToString();
    }
}
