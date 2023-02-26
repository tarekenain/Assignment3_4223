using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinColor : MonoBehaviour
{
    SpriteRenderer pinSR;


    public void Start()
    {
        SetPinColor();
    }

    public void SetPinColor()
    {
        pinSR = GetComponent<SpriteRenderer>();

        var pin = GameObject.FindGameObjectWithTag("Pin").GetComponent<Pin>();
        
        switch(DataManager.loadedCC)
        {
            case 0:
                Debug.Log("Color is set to Black!");
                pinSR.color = Color.black;
                break;
            case 1:
                Debug.Log("Color is set to Blue!");
                pinSR.color = Color.blue;
                break;
            case 2:
                Debug.Log("Color is set to Red!");
                pinSR.color = Color.red;
                break;
            default:
                Debug.Log("Color is set to Black!");
                pinSR.color = Color.black;
                break;
        }
    } 
}
