using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_X", menuName = "Level Settings", order = 51)]
public class LevelSettings : ScriptableObject
{
    [SerializeField] private float speedRotation1;
    [SerializeField] private float timeRotation1;
    [SerializeField] private float speedRotation2;
    [SerializeField] private float timeRotation2;
    [SerializeField] private float speedRotation3;
    [SerializeField] private float timeRotation3;
    [SerializeField] private float speedRotation4;
    [SerializeField] private float timeRotation4;
    
    [SerializeField] private Color backgroundSkin;
    [SerializeField] private Sprite enemySkin;
    [SerializeField] private int countKnife;
    [SerializeField] private float appleProbability;
    
    [SerializeField] private float force;
    [SerializeField] private float timeDelay;
    [SerializeField] private bool boss;
    [SerializeField] private SkinFile newSkin;

    public float SpeedRotation1 => speedRotation1;
    public float SpeedRotation2 => speedRotation2;
    public float SpeedRotation3 => speedRotation3;
    public float SpeedRotation4 => speedRotation4;

    public float TimeRotation1 => timeRotation1;
    public float TimeRotation2 => timeRotation2;
    public float TimeRotation3 => timeRotation3;
    public float TimeRotation4 => timeRotation4;

    public Color BackgroundSkin => backgroundSkin;
    public Sprite EnemySkin => enemySkin;

    public int CountKnife => countKnife;
    public float AppleProbability => appleProbability;

    public float Force => force;
    public float TimeDelay => timeDelay;

    public bool Boss => boss;
    public SkinFile NewSkin => newSkin;
}
