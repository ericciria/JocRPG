using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystemDD : MonoBehaviour
{
    void Awake()
    {

        if (FindObjectsOfType<SaveSystemDD>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
