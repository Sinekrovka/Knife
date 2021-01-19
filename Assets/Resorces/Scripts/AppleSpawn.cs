using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleSpawn : MonoBehaviour
{
    public GameObject apple;
    public GameObject appleCuteLeft;
    public GameObject appleCuteRight;
    
    public WinLose winner;
    public Recording rec;
    public LevelList lvlList;
   
    private LevelSettings lvlSetting;
    private int create;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        lvlSetting = lvlList.Levels[rec.CurrentLevel];
        create = 0;
        rb2d = GetComponent<Rigidbody2D>();
        int element = Random.Range(0, 100);
        if (element <= lvlSetting.AppleProbability*100)
        {
            Instantiate(apple, gameObject.transform);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (create == 1)
        {
            rec.AppleOnLevel += 1;
            Instantiate(appleCuteLeft, gameObject.transform);
            Instantiate(appleCuteRight, gameObject.transform);
            Destroy(gameObject, 0.001f);
        }

        if (winner.Win)
        {
            gameObject.transform.parent = null;
            rb2d.gravityScale = 2;
            transform.Rotate(new Vector3(0,0,transform.rotation.z), Random.Range(-3f, 0f));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Knife")
        {
            create += 1;
        }
    }
}
