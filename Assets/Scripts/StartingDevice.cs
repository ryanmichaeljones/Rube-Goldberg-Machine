using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDevice : MonoBehaviour {

    public Camera cam;
    private Rigidbody rb;
    private float playerSpeed = 0.05f;
    private bool gameStarted = false;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update()
    {
        if (!gameStarted)
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            Vector3 move = new Vector3(horizontalAxis * playerSpeed, 0, 0);
            transform.Translate(move);
        }
        else
        {
            rb.freezeRotation = false;
            //cam.GetComponent<CPC_CameraPath>().PlayPath(35);
            cam.GetComponent<Animator>().SetTrigger("CameraTrigger");
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.name.Contains("Seesaw surface"))
        {
            gameStarted = true;
        }
    }
}
