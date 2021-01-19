using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSkin : MonoBehaviour
{
    public KnifeSkin knife;
    public SkinsList lst;
    private Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.sprite = knife.Knife;
    }

    // Update is called once per frame
    void Update()
    {
        img.sprite = knife.Knife;
        for (int i =0; i<lst.SkinFiles.Count; ++i)
        {
            if (lst.SkinFiles[i].Spr == knife.Knife)
            {
                PlayerPrefs.SetInt("IndexSkin", i);
            }
        }
    }
}
