using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingEffect : MonoBehaviour {

    public AudioSource collisionSound;
    private bool playSound = false;

    void Update()
    {
        if (playSound == true)
        {
            collisionSound.Play();
            playSound = false;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Colliding Object")
        {
            playSound = true;
        }
    }
}
