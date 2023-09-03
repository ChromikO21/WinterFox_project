using UnityEngine;
using System.Collections;

public class LevelWon : MonoBehaviour
{
    public GameObject WinMenu;
    public PlayerMovement PM;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (PM.score == 10) { 
            WinMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}