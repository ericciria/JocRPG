using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class passHouse : MonoBehaviour
{
    [SerializeField] private string sceneName;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {

            SceneManager.LoadScene(sceneName);
            Debug.Log("HOla");
        }



    }
}
