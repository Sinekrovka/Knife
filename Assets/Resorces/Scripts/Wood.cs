using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public WinLose winner;
    public GameObject woodBroken;
    public LevelList lvlList;
    public Recording rec;

    private LevelSettings LvLevelSettings;
    private SpriteRenderer spr;
    private float time;
    private int destroy;
    private float t2;
    private float t3;
    
    void Start()
    {
        LvLevelSettings = lvlList.Levels[rec.CurrentLevel];
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = LvLevelSettings.EnemySkin;
        time = Time.time+LvLevelSettings.TimeRotation1;
        destroy = 0;
    }

    private void FixedUpdate()
    {
        if (time > Time.time)
        {
            transform.Rotate(0f,0f,LvLevelSettings.SpeedRotation1);
        }
        else
        {
            t2 = time + LvLevelSettings.TimeRotation2;
            if (t2 > Time.time)
            {
                transform.Rotate(0f,0f,LvLevelSettings.SpeedRotation2);
            }
            else 
            {
                t3 = t2 + LvLevelSettings.TimeRotation3;
                if (t3 > Time.time)
                {
                    transform.Rotate(0f,0f,LvLevelSettings.SpeedRotation3);
                }
                else
                {
                    if (t3 + LvLevelSettings.TimeRotation4 > Time.time)
                    {
                        transform.Rotate(0f,0f,LvLevelSettings.SpeedRotation4);
                    }
                    else
                    {
                        transform.Rotate(0f,0f,LvLevelSettings.SpeedRotation1);
                        time = Time.time;
                    }
                }
            }
        }
        if (winner.Win && !winner.Lose)
        {
            Vector3 brokenPosition = new Vector3(-0.4f, 0.4f, 0f);
            brokenPosition = transform.position + brokenPosition;
            if (destroy < 1)
            {
                Instantiate(woodBroken, brokenPosition, transform.rotation);
                ++destroy;
            }
            Destroy(gameObject, 0.001f);
        }
    }
}
