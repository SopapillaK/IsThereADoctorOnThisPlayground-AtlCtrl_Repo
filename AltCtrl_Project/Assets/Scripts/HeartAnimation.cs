using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class HeartAnimation : MonoBehaviour
{
    public GameObject HeartNormal;
    public GameObject HeartBig;

    public float interval = 1.0f; // Time in seconds to alternate

    private bool isObjectAActive = true;

    void Start()
    {
        // Start with objectA active and objectB inactive
        HeartNormal.SetActive(true);
        HeartBig.SetActive(false);
        InvokeRepeating("ToggleObjects", interval, interval);
    }

    void ToggleObjects()
    {
        isObjectAActive = !isObjectAActive;
        HeartNormal.SetActive(isObjectAActive);
        HeartBig.SetActive(!isObjectAActive);
    }
}


