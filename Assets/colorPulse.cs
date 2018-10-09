using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPulse : MonoBehaviour
{
    public float colorRed;
    public float colorGreen;
    public float colorBlue;
    public Color pulseColor;
    Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>(); //hämtar renderen component

        //sätter färgerna till ett specielt värde
        colorRed = 1;
        colorGreen = 0;
        colorBlue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pulseColor = new Color(colorRed, colorGreen, colorBlue); //den nya färgen blir en combination av red, green och blue

        colorRed -= 0.1f * Time.deltaTime * 10; //gör så att den röda skalan minskar varje frame med en hastighet av 10

        rend.material.color = pulseColor; //gör så att färgen kan ändras

        if (colorRed < 0) //om colorRed blir mindre än 0
        {
            colorRed = 1; //sätter colorRed till 1 (full färg)
        }
    }
}
