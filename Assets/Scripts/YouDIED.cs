using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouDIED : MonoBehaviour
{
    public GameObject DieMenu;
    public GameObject Player;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.name == "Spikes") || (collision.name == "MapBorder"))
        {
            Player.SetActive(false);
            DieMenu.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("YOU DIED");
        }
    }
}
