using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c2 : MonoBehaviour
{
    private bool isRotating = false;
    private Vector3 rotationOrigin;
    public float rotationSpeed = 5f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

           
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
               
                isRotating = true;
                rotationOrigin = Input.mousePosition;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
          
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 difference = currentMousePosition - rotationOrigin;
            float rotationAngle = -difference.x * rotationSpeed;

            transform.Rotate(0f, 0f, rotationAngle, Space.World);

            rotationOrigin = currentMousePosition;
        }
    }
}
