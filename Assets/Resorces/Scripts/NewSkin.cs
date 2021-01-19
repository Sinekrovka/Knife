using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSkin : MonoBehaviour
{
    public Recording rec;
    public LevelList lvlList;
    public bool images;
    
    private LevelSettings lvlSettings;
    private Image img;
    private Text txt;
    
    // Start is called before the first frame update
    void Start()
    {
        lvlSettings = lvlList.Levels[rec.CurrentLevel];
        img = GetComponent<Image>();
        txt = GetComponent<Text>();
        
        if (lvlSettings.Boss && !lvlSettings.NewSkin.Open)
        {
            if (images)
            {
                img.enabled = true;
                img.sprite = lvlSettings.NewSkin.Spr;
                lvlSettings.NewSkin.Open = true;
                PlayerPrefs.SetInt(lvlSettings.NewSkin.name, lvlSettings.NewSkin.Price);
            }
            else
            {
                txt.enabled = true;
            }
        }
        else
        {
            if (images)
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
