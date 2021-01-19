using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skins : MonoBehaviour
{
    public SkinFile skin;
    public KnifeSkin currentSkin;
    public Recording rec;

    private Text txt;
    private Image img;

    public bool price;
    public bool apple;

    void Start()
    {
        if (price)
        {
            txt = GetComponent<Text>();
            if (apple)
            {
                img = GetComponent<Image>();
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (price)
        {
            if (skin.Price > 0 && skin.Open)
            {
                if (apple)
                {
                    img.enabled = true;
                }
                else
                {
                    txt.enabled = true;
                    txt.text = skin.Price.ToString();
                }
            }
            else if (!skin.Open)
            {
                if (apple)
                {
                    img.enabled = false;
                }
                else
                {
                    txt.enabled = true;
                    txt.text = "LOCK";
                }
            }
            else
            {
                if (apple)
                {
                    img.enabled = false;
                }
                else
                {
                    txt.enabled = false;
                }
            }
            
        }
    }

    public void Select()
    {
        if (skin.Price == 0)
        {
            currentSkin.Knife = skin.Spr;
        }
        if (skin.Open && rec.CountApple >= skin.Price && skin.Price>0)
        {
            rec.CountApple -= skin.Price;
            skin.Price = 0;
            PlayerPrefs.SetInt(skin.name, skin.Price);
        }
    }
}
