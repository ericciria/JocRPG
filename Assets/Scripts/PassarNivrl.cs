using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarNivrl : MonoBehaviour



{

    [SerializeField] private string sceneName;
    [SerializeField] Vector2 playerPos;
    GameObject player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            player.transform.position = playerPos;
            SceneManager.LoadScene(sceneName);
        }
    }

}
