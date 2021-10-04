using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{

    public GameObject cam1, cam2, cam3, cam4;


    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonDown("1key"))
     {
         cam1.SetActive(true);
         cam2.SetActive(false);
         cam3.SetActive(false);
         cam4.SetActive(false);
     }   
          if(Input.GetButtonDown("2key"))
     {
         cam1.SetActive(false);
         cam2.SetActive(true);
         cam3.SetActive(false);
         cam4.SetActive(false);
     }  
          if(Input.GetButtonDown("3key"))
     {
         cam1.SetActive(false);
         cam2.SetActive(false);
         cam3.SetActive(true);
         cam4.SetActive(false);
     }   
          if(Input.GetButtonDown("4key"))
     {
         cam1.SetActive(false);
         cam2.SetActive(false);
         cam3.SetActive(false);
         cam4.SetActive(true);
     }    
    }
}
