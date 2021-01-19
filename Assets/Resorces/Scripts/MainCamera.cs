using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Recording rec;
    public LevelList lvlList;

    private LevelSettings lvlSettings;
    private Camera cam;
    void Start()
    {
        lvlSettings = lvlList.Levels[rec.CurrentLevel];
        cam = GetComponent<Camera>();
        cam.backgroundColor = lvlSettings.BackgroundSkin;
    }

}
