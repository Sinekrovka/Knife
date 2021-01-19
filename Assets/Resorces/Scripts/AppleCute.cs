using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCute : MonoBehaviour
{
    public float rotate;
    void Start()
    {
        transform.parent = null;
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,0,transform.rotation.z), rotate);
    }
}
