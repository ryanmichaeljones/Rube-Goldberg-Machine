using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestruction : MonoBehaviour {

    private float destructionPosition;

    void Start()
    {
        destructionPosition = transform.position.y - 8f;
    }

	void Update()
    {
        if (transform.position.y < destructionPosition)
        {
            Destroy(this.gameObject);
        }
	}
}
