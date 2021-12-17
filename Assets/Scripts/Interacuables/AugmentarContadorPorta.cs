using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugmentarContadorPorta : MonoBehaviour
{
    bool activat;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("A");
        GameObject porta = GameObject.Find("Gate");
        if (porta != null)
        {
            Porta portap = porta.GetComponent<Porta>();
            portap.contador++;
            if (portap.contador == 2)
            {
                portap.Moure();
            }
        }
    }
}
