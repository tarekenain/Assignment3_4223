using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public DataManager dataManager;
    public float speed = 100f;
    SpriteRenderer rotatorSR;

    void Update() 
    {
        speed = speed * DataManager.realSpeed;
        
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }


    public void Start()
    {
        SetRotatorColor();
    }

    public void SetRotatorColor()
    {
        rotatorSR = GetComponent<SpriteRenderer>();

        switch(DataManager.loadedCC)
        {
            case 0:
                Debug.Log("Color is set to Black!");
                rotatorSR.color = Color.black;

                break;
            case 1:
                Debug.Log("Color is set to Blue!");
                rotatorSR.color = Color.blue;
                break;
            case 2:
                Debug.Log("Color is set to Red!");
                rotatorSR.color = Color.red;
                break;
            default:
                Debug.Log("Color is set to Black!");
                rotatorSR.color = Color.black;
                break;
        }
    } 

}
