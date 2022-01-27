using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVidaGermana : MonoBehaviour
{
    private Text text;
    public int vida, vidamax;
    public bool temporitzadorVida;
    public bool guanyat = false;
    GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("GameOver");
        text = GetComponent<Text>();
        text.text = "Salut Germana: " + vida;
        temporitzadorVida = true;
    }

    // Update is called once per frame
    void Update()
    {
        startCorroutine();
        if (vida <= 0)
        {
            gameOver.SetActive(true);
            guanyat = true;
        }
    }

    public void startCorroutine()
    {
        if (temporitzadorVida && !guanyat)
        {
            StartCoroutine(treureVida());
            temporitzadorVida = false;

        }
    }

    IEnumerator treureVida()
    {
        yield return new WaitForSeconds(1);
        vida -= 1;
        text.text = "Salut Germana: " + vida;
        temporitzadorVida = true;

    }
}
