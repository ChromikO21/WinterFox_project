using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public PlayerMovement PM;
    public Animator gemAnimator;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.name == "GemCollector")) {
            GetComponent<BoxCollider2D>().enabled = false;
            gemAnimator.SetBool("Collected", true);
            PM.ScorePlus();
            Destroy(gameObject, (1));
        }
    }
}
