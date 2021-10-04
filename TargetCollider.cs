using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour
{
    int blocksCount;

    public GameObject levelCompleteScreen;


    void Update()
    {
        if (blocksCount == 0)
        {
            levelCompleteScreen.SetActive(true);
        }
        else
        {
            levelCompleteScreen.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            blocksCount += 1;
    }
    private void OnTriggerExit(Collider other)
    {
            blocksCount -= 1;
    }
}
