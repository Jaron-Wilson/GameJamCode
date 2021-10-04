using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject targetPlane;

    public GameObject levelCompleteScreen;

    public GameObject continueButton;
    public GameObject restartButton;
    public GameObject hideButton;
    public GameObject showButton;



    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void HideTarget()
    {
        targetPlane.SetActive(false);
        hideButton.SetActive(false);
        showButton.SetActive(true);
    }

    public void ShowTarget()
    {
        targetPlane.SetActive(true);
        hideButton.SetActive(true);
        showButton.SetActive(false);
    }

    public void NextLevel()
    {
        levelCompleteScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        levelCompleteScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
