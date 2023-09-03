using UnityEngine;
using System.Collections;

public class Activator : MonoBehaviour
{
    public GameObject platformActivate;

    void OnTriggerEnter2D(Collider2D collision)
    {

        platformActivate.SetActive(true);
    }
}