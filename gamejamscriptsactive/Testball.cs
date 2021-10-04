using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testball : MonoBehaviour
{
    // public Rigidbody ball;
    // public float force = 20f;

    // void Start()
    // {
    //     ball = GetComponent<Rigidbody>();

    //     ball.AddForce(0, 0, force, ForceMode.Impulse);
    // }




    public Rigidbody ball;

 public float forwardForce = 2000f;

    void Start()
    {
                ball = GetComponent<Rigidbody>();

        // ball.AddForce(0, 0, forwardForce, ForceMode.Impulse);
    }

 void FixedUpdate()
 {
     ball.AddForce(0, 0, forwardForce * Time.deltaTime);
 }
 public void onPress() //when press you move
 {
    //  ball.AddForce(forwardForce * Time.deltaTime, 0, 0, forwardForce.VelocityChange);
    
        // Vector3 moveSpeed = new Vector3(5000f, 0.0f, 5000f);
        ball.AddForce(0, 0, forwardForce, ForceMode.Impulse);
        // ballRigidBody.AddForce(magnitudeOfForce * cameraTransform.forward);
 }

 public void onRelease() //when not press you stop moving
 {
     ball.AddForce(0, 0, 0, 0);
 }
}
