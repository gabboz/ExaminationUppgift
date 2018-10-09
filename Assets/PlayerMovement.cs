using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float shipSpeed;
    public float rotationSpeedRight;
    public float rotationSpeedLeft;
    public SpriteRenderer shipRend;
    public Color newColor;
    public int x;
    public float timer;
    public float red;
    public float green;
    public float blue;
    public Transform shipSpawn;
    public float randomisedX_Coordinates;
    public float randomisedY_Coordinates;

    // Use this for initialization
    void Start()
    {
        shipSpeed = Random.Range(1, 11);  //slumpar skeppets fart 
        randomisedX_Coordinates = Random.Range(-8.5f, 8.5f); //slumpar skeppets X kordinater
        randomisedY_Coordinates = Random.Range(-4.5f, 4.5f); //slumpar skeppets Y kordinater
        shipSpawn.position = new Vector3(randomisedX_Coordinates, randomisedY_Coordinates); //tar X och Y kordinaterna och placerar skeppet med vector 
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer += Time.deltaTime; //timer variabel som konsistent ökar varje frame och asisterar linje 62-66
        transform.Translate(shipSpeed * Time.deltaTime, 0, 0, Space.Self); //gör så att skeppet rör sig framåt automatiskt

        if (Input.GetKey(KeyCode.D)) //om D:knappen trycks in
        {
            transform.Rotate(0, 0, rotationSpeedRight * Time.deltaTime); //gör att skeppet roterar åt höger
            shipRend.color = newColor; //gör så att skeppet kan få en ny färg
            shipRend.color = new Color(0f, 0f, 1f); //sätter en ny färg på skeppet
        }
        if (Input.GetKey(KeyCode.A)) //om A:knappen trycks ner
        {
            transform.Rotate(0, 0, rotationSpeedLeft * Time.deltaTime); //gör att skeppet roterar åt vänster
            shipRend.color = newColor; //gör så att skeppet kan få en ny färg
            shipRend.color = new Color(0f, 1f, 0.07f); //sätter en ny färg på skeppet
        }
        if (Input.GetKeyDown(KeyCode.S)) //om S:knappen hålls nere
        {
            shipSpeed = shipSpeed / 2; //halverar skeppets fart
        }
        if (Input.GetKeyUp(KeyCode.S)) //när S:knappen släpps
        {
            shipSpeed = shipSpeed * 2; //gör att skeppet återgår till sin orginal fart
        }
        if (Input.GetKeyDown(KeyCode.Space)) //om spacebar trycks ner
        {
            red = Random.Range(0, 1f); //slumpar red
            green = Random.Range(0, 1f); //slumpar green
            blue = Random.Range(0, 1f); //slumpar blue
            shipRend.color = newColor; //gör så att skeppet kan få en ny färg
            shipRend.color = new Color(red, green, blue); //sätter en ny färg på skeppet med hjälp av red, green, blue 
        }
        if (timer > x) //om timer variabeln går över X
        {
            print("Timer: " + x); //skriver timer och X värdet
            x = x + 1; //lägger till 1 till X värdet
        }
    }
}
