using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class HeartAnimation : MonoBehaviour
{

    public GameObject HeartNormal;
    public GameObject HeartBig;


    private int counter = 0;
    private float switchTime = 0.3f; // Time between switches



    void Update()

    {
        counter++;
        if (Time.time > switchTime)
        {
            if (counter % 2 == 0)
            {
                HeartNormal.SetActive(true);
                HeartBig.SetActive(false);
            }
            else
            {
                HeartNormal.SetActive(false);
                HeartBig.SetActive(true);
            }

            counter = 0;
            switchTime = Time.time + 1f; // Reset switch time

        }
    }
}

