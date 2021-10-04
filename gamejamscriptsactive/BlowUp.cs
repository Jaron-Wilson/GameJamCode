using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlowUp : MonoBehaviour
{


       
   
    public GameObject tnt;


 public int selectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();

        // Spawntnt();

        // InvokeRepeating("Spawntnt", 1f , 2f);
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if(i == selectedWeapon)
                weapon.gameObject.SetActive(true);
                else
                    weapon.gameObject.SetActive(false);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon >= transform.childCount - 1)
            selectedWeapon = 0;
            else
            selectedWeapon++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon <= 0)
            selectedWeapon = transform.childCount -1;
            else
            selectedWeapon--;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }


            if (Input.GetMouseButtonDown(1))//right mouse button
        {
            Vector3 mousePos = Input.mousePosition;

            mousePos.z = 5.5f;
            
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);
        
        Instantiate(tnt, spawnPos, Quaternion.identity);

        }
    }

    
}
