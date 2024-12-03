using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    public GameObject prefab;

    private List<T> pooledObjects;

    public ObjectPool(T prefab, int initialSize)
    {
        pooledObjects = new List<T>();
        for (int i = 0; i < initialSize; i++)
        {
            T obj = Instantiate(prefab);
            obj.gameObject.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public T GetObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].gameObject.activeInHierarchy)
            {
                pooledObjects[i].gameObject.SetActive(true);
                return pooledObjects[i];

            }
        }

        T obj = Instantiate(prefab);
        pooledObjects.Add(obj);
        return obj;
    }

    public void ReturnObject(T obj)
    {
        obj.gameObject.SetActive(false);
    }
}

