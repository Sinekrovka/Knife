using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private bool finish;
    private int count;
    
    public GameObject canvasWin;
    public GameObject canvasLose;
    public Recording rec;
    public WinLose winner;
    
    void Start()
    {
        count = 0;
        finish = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (finish && count==0)
        {
            Instantiate(canvasWin);
            count++;
        }
        
        if (winner.Lose && count==0)
        {
            rec.Touch = false;
            rec.AppleOnLevel = 0;
            Instantiate(canvasLose);
            count ++;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wood")
        {
            finish = true;
            if (rec.MaxLevel < rec.CurrentLevel)
            {
                rec.MaxLevel = rec.CurrentLevel;
            }

            rec.CountApple += rec.AppleOnLevel;
            rec.AppleOnLevel = 0;
        }
        Destroy(other.gameObject);
    }
}
