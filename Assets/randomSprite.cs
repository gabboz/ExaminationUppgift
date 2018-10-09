using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSprite : MonoBehaviour {
    public SpriteRenderer shipRend;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public int spriteRandom;
    // Use this for initialization
    void Start () {

        //en float som får ett slumpat värde
        spriteRandom = Random.Range(0, 3);

        //om randomSprite slumpar 0 så kommer sprite1 att synas
        if (spriteRandom == 0)
        {
            shipRend.sprite = sprite1;
        }
        //om randomSprite slumpar 1 så kommer sprite2 att synas
        else if (spriteRandom == 1)
        {
            shipRend.sprite = sprite2;
        }
        //om randomSprite inte får någon av de övre så kommer sprite3 att synas
        else
        {
            shipRend.sprite = sprite3;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
