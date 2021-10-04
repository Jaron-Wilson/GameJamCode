using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    // public AudioClip audioSound;
        private void Awake()
    {
        // GetComponent<AudioSource>().PlayOneShot(audioSound);
    }
    
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
