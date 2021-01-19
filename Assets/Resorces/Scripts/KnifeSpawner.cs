using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class KnifeSpawner : MonoBehaviour
{
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        knife.tag = "ExitKnife";
        createObject();
        knife.tag = "Knife";
    }

    private void createObject()
    {
        int countknife = Random.Range(1, 3);
        for (int i = 0; i < countknife; ++i)
        {
            float angle;
            int f = Random.Range(1, 4);
            if (f == 1)
            {
                angle = Random.Range(15f, 75f);
            }
            else if (f == 2)
            {
                angle = Random.Range(105f, 165f);
            }
            else if (f == 3)
            {
                angle = Random.Range(195f, 255f);
            }
            else
            {
                angle = Random.Range(275f, 345f);
            }
            
            transform.parent.rotation = Quaternion.Euler(0f,0f,angle);
            Vector3 positionX = new Vector3(0f,0f,0f);
            Instantiate(knife, positionX, Quaternion.Euler(0f,0f,0f), transform.parent);
        }
    }
}
