using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

    public GameObject effectObject;
    public GameObject collisionObject;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.name == collisionObject.name)
        {
            GetComponent<Rigidbody>().useGravity = true;
            effectObject.GetComponent<Rigidbody>().useGravity = true;
            effectObject.GetComponent<Rigidbody>().AddForce(new Vector3(100, 0, 0));
        }
    }
}
