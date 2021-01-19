using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public Recording rec;
    public bool apple;
    public bool current;

    private Text txt;
    
    private void Start()
    {
        txt = GetComponent<Text>();
        int x;
        if (apple)
        {
            txt.text = rec.CountApple.ToString();
        }
        else
        {
            if (current)
            {
                x = rec.CurrentLevel + 1;
                txt.text = x.ToString();
            }
            else
            {
                x = rec.MaxLevel + 1;
                txt.text = x.ToString();
            }
            
        }
    }

    private void Update()
    {
        if (apple)
        {
            txt.text = rec.CountApple.ToString();
        }
    }
}
