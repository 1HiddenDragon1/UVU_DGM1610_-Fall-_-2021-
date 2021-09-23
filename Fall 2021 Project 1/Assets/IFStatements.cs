using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    //giving definitions of the coffee heat and how high hot and cold are
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f
    }

    void TemperatureTest ()
    {
        //if the coffee temp is greater than hottest drinking temperature
        if(coffeeTemperature > hotLimitTemperature)
        {
            //... then do this
            print("The coffee is too hot to drink.");
        }
        //if it isn't too hot to drink, but the coffe temp is less than coldest drinking temp
        else if(coffeeTemperature < coldLimitTemperature)
        {
            //... then do this instead
            print("The coffee is too cold. It isn't worth drinking.");
        }
        //if it is neither the if nor else if
        else
        {
            //... then it will do this
            print("*Sip* Ahhhh, the coffee's temperature is just right.");
        }
    }
}
