using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] public GameObject objecte;
    private Vector2 pos;



    private void Start()
    {
        pos = objecte.transform.position;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ResetObject();
            GameObject porta = GameObject.Find("Gate");
            if (porta != null){
                Porta portap = porta.GetComponent<Porta>();
                portap.contador = 0;
            }
            
        }
        
    }

    public void ResetObject()
    {
        objecte.transform.position = pos;
    }
}
