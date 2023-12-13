using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundY : MonoBehaviour
{
    private bool isRotating = false;
    private Quaternion originalRotation;
    private Quaternion targetRotation;
    public float angle = -90;


    void Start()
    {
        originalRotation = transform.rotation;
        targetRotation = originalRotation;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            targetRotation = Quaternion.Euler(0, angle, 0);
            angle -= 90;
            //angle = Mathf.Clamp(angle, 0, 360);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
    }
}
