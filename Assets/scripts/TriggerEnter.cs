using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public GameObject lava;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        lava.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        lava.SetActive(false);
    }
}
