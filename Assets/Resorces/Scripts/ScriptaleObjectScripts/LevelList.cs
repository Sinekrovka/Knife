using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level Manager", menuName = "Level Manager", order = 55)]
public class LevelList : ScriptableObject
{
    [SerializeField] private List<LevelSettings> levels;

    public List<LevelSettings> Levels => levels;
}
