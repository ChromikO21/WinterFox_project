using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{


    public GameObject resetLevelMenuUI;

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        resetLevelMenuUI.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
        resetLevelMenuUI.SetActive(false);
    }

    public void ResetLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        resetLevelMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

}