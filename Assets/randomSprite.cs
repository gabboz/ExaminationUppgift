using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSprite : MonoBehaviour
{
    public SpriteRenderer shipRend;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public int spriteRandom;
    // Use this for initialization
    void Start()
    {
        spriteRandom = Random.Range(0, 3); //slumpar spriteRandom:s värde


        if (spriteRandom == 0) //om spriteRandom är 0
        {
            shipRend.sprite = sprite1; //vissar sprite1
        }
        else if (spriteRandom == 1) //om spriteRandom är 1
        {
            shipRend.sprite = sprite2; //vissar sprite2
        }
        else //om spriteRandom inte är någon av de övre
        {
            shipRend.sprite = sprite3; //vissar sprite3
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
