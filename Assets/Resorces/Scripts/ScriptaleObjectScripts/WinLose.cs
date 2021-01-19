using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WinLose", menuName = "Win or Lose", order = 53)]
public class WinLose : ScriptableObject
{
    [SerializeField] private bool win;
    [SerializeField] private bool lose;
    [SerializeField] private int countknife;

    public bool Win
    {
        get => win;
        set => win = value;
    }

    public bool Lose
    {
        get => lose;
        set => lose = value;
    }

    public int Countknife
    {
        get => countknife;
        set => countknife = value;
    }
}
