using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skin_X", menuName = "Create Skin", order = 56)]
public class SkinFile : ScriptableObject
{
    [SerializeField] private int price;
    [SerializeField] private Sprite spr;
    [SerializeField] private bool open;

    public Sprite Spr
    {
        get => spr;
    } 

    public int Price
    {
        get => price;
        set => price = value;
    }

    public bool Open
    {
        get => open;
        set => open = value;
    }
}
