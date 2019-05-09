using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private Camera cam;
    private float navigationSpeed = 0.3f;
    private float scrollSpeed = 20f;
    private float minScrollDistance = 50f;
    private float maxScrollDistance = 100f;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        cam.fieldOfView += scroll * scrollSpeed;
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minScrollDistance, maxScrollDistance);

        if (Input.GetMouseButton(2))
        {
            float horizontalMouse = Input.GetAxis("Mouse X");
            float verticalMouse = Input.GetAxis("Mouse Y");
            transform.Translate(new Vector3(-horizontalMouse * navigationSpeed, -verticalMouse * navigationSpeed, 0));
        }
    }
}
