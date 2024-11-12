using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 2f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position,transform.rotation);
            Destroy(spawnedObject, 4.0f); // Adjust the destruction time as needed

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

