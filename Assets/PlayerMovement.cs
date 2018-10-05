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
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //timer variabel som konsistent ökar varje frame och asisterar linje 62-66
        timer = timer += Time.deltaTime;
        //gör så att skeppet rör sig framåt automatiskt
        transform.Translate(shipSpeed * Time.deltaTime, 0, 0, Space.Self);

        //när D:knappen trycks ner snurar skeppet åt höger och blir blått
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, rotationSpeedRight * Time.deltaTime);
            shipRend.color = newColor;
            shipRend.color = new Color(0f, 0f, 1f);
        }
        //när A:knappen trycks ner snurar skeppet åt vänster och blir grönt
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationSpeedLeft * Time.deltaTime);
            shipRend.color = newColor;
            shipRend.color = new Color(0f, 1f, 0.07f);
        }
        //när S:knappen är nedtryckt halveras skeppets fart
        if(Input.GetKeyDown(KeyCode.S))
        {
            shipSpeed = shipSpeed / 2;
        }
        //när S;knappen släpps så dubblas skeppets fart
        if(Input.GetKeyUp(KeyCode.S))
        {
            shipSpeed = shipSpeed * 2;
        }
        //när spacebar trycks ner randomiseras en färg på skeppet
        if(Input.GetKeyDown(KeyCode.Space))
        {
            red = Random.Range(0, 1f);
            green = Random.Range(0, 1f);
            blue = Random.Range(0, 1f);
            shipRend.color = newColor;
            shipRend.color = new Color(red,green,blue);

        }
        //en timer som konstant ränkar sekunder med decimaler
        if(timer > x)
        {
            print("Timer: " + x);
            x = x + 1;
        }
    }
}
