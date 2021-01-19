using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Knife", menuName = "Knife skin", order = 52)]
public class KnifeSkin : ScriptableObject
{
    [SerializeField] private Sprite knife;

    public Sprite Knife
    {
        get => knife;
        set => knife = value;
    }
}
