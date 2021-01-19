using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeCount : MonoBehaviour
{
    public bool now;
    public Recording rec;
    public LevelList lvlList;
    public WinLose winner;

    private LevelSettings lvlSettings;
    private Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
        lvlSettings = lvlList.Levels[rec.CurrentLevel];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (now)
        {
            int x = 1 + winner.Countknife;
            txt.text = x.ToString();
        }
        else
        {
            txt.text = lvlSettings.CountKnife.ToString();
        }
    }
}
