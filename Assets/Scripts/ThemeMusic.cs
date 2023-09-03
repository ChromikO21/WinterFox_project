using System;
using UnityEngine;

public class ThemeMusic : MonoBehaviour
{
    public static ThemeMusic instance;
void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
