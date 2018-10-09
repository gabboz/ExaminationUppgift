using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWarp : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gör en vector variabel som sätter värdet på variabeln till skeppets position
        Vector3 newPosition = transform.position; 

        if(newPosition.x > 8.85 || newPosition.x < -8.85) //om skeppets position på x axeln är större än 8.85 eller mindre än -8.85 (kamerans höger och vänster sida) 
        {
            newPosition.x = -newPosition.x; //så kommer skeppets position att bli motsat vad den är
        }
        if (newPosition.y > 5 || newPosition.y < -5) //om skeppets position är på Y axeln är större än 5 eller mindre än -5 (kamerans top och boten sida)
        {
            newPosition.y = -newPosition.y; //så kommer skeppets position att bli motsat vad den är
        }
        transform.position = newPosition; //sätter transform värdet till skeppets position
    }
}
