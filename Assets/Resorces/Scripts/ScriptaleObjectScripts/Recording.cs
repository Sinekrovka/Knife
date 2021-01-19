using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recording", menuName = "Recording", order = 54)]

public class Recording : ScriptableObject
{
    [SerializeField] private int countApple;
    [SerializeField] private int maxLevel;
    [SerializeField] private int currentLevel;
    [SerializeField] private int appleOnLevel;
    [SerializeField] private bool touch;

    public int CountApple
    {
        get => countApple;
        set => countApple = value;
    }

    public int MaxLevel
    {
        get => maxLevel;
        set => maxLevel = value;
    }

    public int CurrentLevel
    {
        get => currentLevel;
        set => currentLevel = value;
    }

    public int AppleOnLevel
    {
        get => appleOnLevel;
        set => appleOnLevel = value;
    }

    public bool Touch
    {
        get => touch;
        set => touch = value;
    }
}


