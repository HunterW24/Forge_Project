using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackAndForth : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float rotationAmount = 30f;

    private float currentRotation = 0f;
    private bool isRotatingForward = true;

    void Update()
    {
        if (isRotatingForward)
        {
            currentRotation += rotationSpeed * Time.deltaTime;
            if (currentRotation >= rotationAmount)
            {
                isRotatingForward = false;
            }
        }
        else
        {
            currentRotation -= rotationSpeed * Time.deltaTime;
            if (currentRotation <= -rotationAmount)
            {
                isRotatingForward = true;
            }
        }

        transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }
}
