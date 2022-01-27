using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerDD : MonoBehaviour
{
    void Awake()
    {

        if (FindObjectsOfType<MenuManagerDD>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
