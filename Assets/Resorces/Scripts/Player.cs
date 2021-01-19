using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject knifePrefab;
    public Recording rec;
    public LevelList lvlList;
    public WinLose winner;
    
    private LevelSettings lvlSetting;
    private GameObject newKnife;
    private float shotTime;
    private bool click;
    void Start()
    {
        lvlSetting = lvlList.Levels[rec.CurrentLevel];
        newKnife = Instantiate(knifePrefab);
        winner.Countknife = lvlSetting.CountKnife -1;
        shotTime = Time.time;
        click = false;
        if (lvlSetting.Boss)
        {
            rec.Touch = false;
        }
        else
        {
            rec.Touch = true;
        }
        winner.Lose = false;
        winner.Win = false;
        
        Vibration.Init();
    }

    private void FixedUpdate()
    {
        if (rec.Touch)
        {
            if ((Input.touchCount > 0 || Input.GetButton("Fire1"))&& !click)
            {
                if (!click)
                {
                    newKnife.GetComponent<Rigidbody2D>().AddForce(Vector2.up * lvlSetting.Force, ForceMode2D.Impulse);
                    shotTime = Time.time + lvlSetting.TimeDelay;
                    click = true;
                }
            }
        
            if ( click && Time.time > shotTime && winner.Countknife >0)
            {
                newKnife = Instantiate(knifePrefab);
                click = false;
            }
        }
        else
        {
            if ((Input.touchCount > 0 || Input.GetButton("Fire1")) && !winner.Lose)
            {
                rec.Touch = true;
            }
        }

    }
}
