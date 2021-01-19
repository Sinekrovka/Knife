using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public Recording rec;
    public SkinsList skinsList;
    public KnifeSkin currentSkin;
    void Start()
    {
        rec.CountApple = PlayerPrefs.GetInt("AppleCount");
        rec.MaxLevel = PlayerPrefs.GetInt("MaxLevel");
        rec.CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");

        for (int i = 0; i < skinsList.SkinFiles.Count; ++i)
        {
            if (PlayerPrefs.HasKey(skinsList.SkinFiles[i].name))
            {
                skinsList.SkinFiles[i].Price = PlayerPrefs.GetInt(skinsList.SkinFiles[i].name);
                skinsList.SkinFiles[i].Open = true;
            }
        }

        if (PlayerPrefs.HasKey("IndexSkin"))
        {
            int index = PlayerPrefs.GetInt("IndexSkin");
            currentSkin.Knife = skinsList.SkinFiles[index].Spr;
        }
    }
}
