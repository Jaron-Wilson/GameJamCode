using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAboutOrigin : MonoBehaviour
{
    public GameObject origin;
    public float rotateAngle = 1;
    public bool invert = false;
    public int invertInt;


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            origin.transform.Rotate(0, -1 * rotateAngle, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            origin.transform.Rotate(0, rotateAngle, 0);
        }
    }
}
