using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{


    public GameObject nextLevelMenuUI;

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        nextLevelMenuUI.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
        nextLevelMenuUI.SetActive(false);
    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        nextLevelMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

}