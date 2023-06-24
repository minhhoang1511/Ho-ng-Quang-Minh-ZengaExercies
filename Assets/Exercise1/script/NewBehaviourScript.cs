using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera mainCamera;
    public Transform quadTransform;
    private Plane quadPlane;

    void Start()
    {
        quadPlane = new Plane(quadTransform.up, quadTransform.position);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            float rayDistance;

            if (quadPlane.Raycast(ray, out rayDistance))
            {
                Vector3 hitPoint = ray.GetPoint(rayDistance);
                transform.position = hitPoint;
            }
        }
    }
}
