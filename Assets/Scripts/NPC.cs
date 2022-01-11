using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    private int contadorLinies;
    public GameObject text, victoria;
    public Text linies;
    public PlayerController player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        contadorLinies = 0;
        text = GameObject.Find("Dialeg");
        text.SetActive(!text.activeSelf);
    }

    /*public void NPCDialogue()
    {
        text.SetActive(true);
        contadorLinies += 1;
        if (contadorLinies < 2)
        {
            linies.text = "Bon dia aventurer, a partir d'aqui hi han enemics, ves amb compte";
            StartCoroutine(Contador());
        }
        else if(contadorLinies < 3)
        {
            linies.text = "Veig que encara segueixes viu, bona feina";
            StartCoroutine(Contador());
        }
        else if (contadorLinies < 4)
        {
            linies.text = "Necessito que eliminis tots els enemics de la zona";
            StartCoroutine(Contador());
        }
        else if (player.enemies < 1)
        {
            linies.text = "Enhorabona, has derrotat a tots els enemics";
            StartCoroutine(Contador());
            victoria.SetActive(true);
            Time.timeScale = 0;
        }

    }*/

    IEnumerator Contador()
    {
        yield return new WaitForSeconds(6);
        text.SetActive(false);
    }

}
