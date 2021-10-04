using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody pl;

    float xInput;
    float zInput;

    public float moveSpeed;

    // public AudioClip audioSound;
    // public AudioClip coinSound;

    private void Awake()
    {
        pl = GetComponent<Rigidbody>();
        // GetComponent<AudioSource>().PlayOneShot(audioSound);
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
      zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float xVelocity = xInput * moveSpeed;
         float zVelocity = zInput * moveSpeed;

        pl.velocity = new Vector3(xVelocity, pl.velocity.y);//, zVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blocks")
        {
            Destroy(collision.gameObject);

            // GetComponent<AudioSource>().Play();
            // GetComponent<AudioSource>().PlayOneShot(coinSound);
        }
    }
}
