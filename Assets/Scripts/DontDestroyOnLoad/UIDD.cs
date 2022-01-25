using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDD : MonoBehaviour
{
    void Awake()
    {

        if (FindObjectsOfType<UIDD>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
