using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScreen : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.touchCount > 0 || Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("DefaultLevel");
        }
    }
}
