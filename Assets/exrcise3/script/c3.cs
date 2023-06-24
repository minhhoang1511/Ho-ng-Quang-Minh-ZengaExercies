using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c3 : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float leftLimit = -45f;
    public float rightLimit = 45f;

    private float rotationX = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            rotationX += mouseX * rotationSpeed;

            // Giới hạn góc xoay 
            rotationX = Mathf.Clamp(rotationX, leftLimit, rightLimit);

            // Xoay camera quanh trục y 
            transform.localRotation = Quaternion.Euler(0f, rotationX, 0f);
        }
    }
}
