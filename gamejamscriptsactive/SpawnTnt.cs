using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnTnt : MonoBehaviour
{



    public Transform spawnPoint;
    public string mainMenu;

    public float maxX;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {

      
        // Spawntnt();

        // InvokeRepeating("Spawntnt", 1f , 2f);
    }



    // Update is called once per frame
    void Update()
    {



        // if (Input.GetKeyDown(KeyCode.Q)) //Spawn ball at the transform
        // {
        //     SpawnTnt();
        // }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(mainMenu);
        }


        
        
    }

    // void SpawnTnt()
    // {


    //     float randomX = Random.Range(-maxX,maxX);
    //     float randomZ = Random.Range(-maxZ,maxZ);

    //     Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);

    //       Instantiate(tnt, randomSpawnPos, Quaternion.identity);
    //     // Instantiate(tnt, spawnPoint.position, Quaternion.identity);
    // }
}
