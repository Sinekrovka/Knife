using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinList", menuName = "Create SkinList", order = 57)]
public class SkinsList : ScriptableObject
{
    [SerializeField] private List<SkinFile> skinFiles;

    public List<SkinFile> SkinFiles => skinFiles;
}
