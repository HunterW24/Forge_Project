using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BucketSpawn : MonoBehaviour
{

    public GameObject bucket;
    public GameObject lava;
    public double bucketRotation = 93;

    public void Update()
    {
        Debug.Log(bucket.transform.rotation.z);
        if (bucket.transform.rotation.z >= -.75f && bucket.transform.rotation.z <= -.5f || bucket.transform.rotation.z <= .75f && bucket.transform.rotation.z >= .5f)
        {
           lava.SetActive(true);
        }

        else
        {
            lava.SetActive(false);
        }
    }
}

