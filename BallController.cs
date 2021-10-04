using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {

        GetComponent<Renderer>().material.color = Color.red;

    }
 void Update()
    {
    if (Input.GetKeyDown(KeyCode.R))
    {
        SceneManager.LoadScene("Part3");
    }
    }


}
