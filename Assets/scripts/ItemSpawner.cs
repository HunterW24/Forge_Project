using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnRadius = 5f;
    public float rotationThreshold = 360f;
    public float spawnInterval = 1f;
    public float rotationSpeed = 10f;

    private float currentRotation = 0f;
    private List<GameObject> spawnedItems = new List<GameObject>();

    void Update()
    {
        currentRotation += Time.deltaTime * rotationSpeed;

        if (currentRotation >= spawnInterval)
        {
            currentRotation -= spawnInterval;
            SpawnItem();
        }

        if (currentRotation >= rotationThreshold)
        {
            DeleteItems();
        }
    }

    void SpawnItem()
    {
        GameObject newItem = Instantiate(itemPrefab);
        newItem.transform.SetParent(transform);
        newItem.transform.localPosition = new Vector3(Mathf.Cos(currentRotation * Mathf.Deg2Rad) * spawnRadius, 0f, Mathf.Sin(currentRotation * Mathf.Deg2Rad) * spawnRadius);
        spawnedItems.Add(newItem);
    }

    void DeleteItems()
    {
        for (int i = spawnedItems.Count - 1; i >= 0; i--)
        {
            Destroy(spawnedItems[i]);
            spawnedItems.RemoveAt(i);
        }
    }
}
