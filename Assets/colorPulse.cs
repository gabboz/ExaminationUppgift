using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPulse : MonoBehaviour {
    public float colorRed;
    public float colorGreen;
    public float colorBlue;
    public Color pulseColor;
    Renderer rend;

	// Use this for initialization
	void Start () {
        //hämtar renderen component
        rend = GetComponent<Renderer>();
        //sätter färgerna till ett specielt värde
        colorRed = 1;
        colorGreen = 0;
        colorBlue = 0;

	}
	
	// Update is called once per frame
	void Update () {
        //den nya färgen blir en combination av red, green och blue
        pulseColor = new Color(colorRed, colorGreen, colorBlue);

        //gör så att den röda skalan minskar varje frame 
        colorRed -= 0.1f * Time.deltaTime * 10;

        //gör så att färgen kan ändras
        rend.material.color = pulseColor;

        //om den röda skalan når 0 så kommer den att sätta tillbaka till 1 (full färg)
        if(colorRed < 0)
        {
            colorRed = 1;
        }
    }
}
