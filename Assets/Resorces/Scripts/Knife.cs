using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Knife : MonoBehaviour
{
    public KnifeSkin knife;
    public WinLose winner;
    
    private SpriteRenderer spr;
    private Rigidbody2D rb2d;
	private int z;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = knife.Knife;
		z=0;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wood" && gameObject.tag == "Knife")
        {
            rb2d.velocity = Vector2.zero;
            transform.parent = other.transform;
            gameObject.tag = "ExitKnife";
            winner.Countknife -= 1;
            Vibration.Vibrate(25);
            
        }

        if (other.gameObject.tag == "ExitKnife" && gameObject.tag == "Knife")
        {
            rb2d.velocity = Vector2.zero;
            rb2d.gravityScale = 5;
            Vibration.VibrateNope();
            winner.Lose = true;
            winner.Countknife = 0;
        }
    }

    private void Update()
    {
        if (winner.Countknife == -1 && !winner.Lose)
        {
            winner.Win = true;
            transform.parent = null;
            //transform.Rotate(new Vector3(0,0,transform.rotation.z), Random.Range(-8f, 0f));
            rb2d.gravityScale = 3;
        }
		if(z<2)
		{
			spr.sprite = knife.Knife;
			++z;
		}
    }
}
