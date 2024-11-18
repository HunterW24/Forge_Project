using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForward : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float targetRotation = 93f;

    bool isRotatingForward = true;

    void Update()
    {
        if (isRotatingForward)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

            if (transform.eulerAngles.z >= targetRotation)
            {
                isRotatingForward = false;
            }
        }
        else
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);

            if (transform.eulerAngles.z <= 0.1f) // Adjust the tolerance as needed
            {
                isRotatingForward = true;
            }
        }
    }
}
