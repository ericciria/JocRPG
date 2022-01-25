using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDD : MonoBehaviour
{
        void Awake()
        {

            if (FindObjectsOfType<CameraDD>().Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }
}
