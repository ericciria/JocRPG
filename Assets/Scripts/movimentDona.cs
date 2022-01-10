using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentDona : MonoBehaviour
{
    [SerializeField] SpriteRenderer vidaSprite;
    [SerializeField] Text text;
    Animator anim;
    bool potCambiar, temporitzadorVida;
    Rigidbody2D rb;
    Vector2 mov;
    int vida, vidamax;
    public PlayerController v;
    // Start is called before the first frame update
    void Start()
    {
        vidamax = 10;
        vida = vidamax;
        rb = GetComponent<Rigidbody2D>();
        potCambiar = true;
        temporitzadorVida = true;
        mov = new Vector2(0, 2);
        anim = GetComponent<Animator>();
        text.text = "Salut Germana: " + vida;
    }

    // Update is called once per frame
    void Update()
    {
        if (temporitzadorVida)
        {
            StartCoroutine(treureVida());
            temporitzadorVida = false;

        }
        if (vida <= 0)
        {
            Destroy(gameObject);
        }



        if (potCambiar)
        {
            StartCoroutine(Moure());
            potCambiar = false;
        }

        if (mov != Vector2.zero)
        {
            anim.SetFloat("movVertical", mov.y);
            anim.SetFloat("movLateral", mov.x);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * Time.fixedDeltaTime);
    }
    IEnumerator Moure()
    {
        yield return new WaitForSeconds(5);
        mov =mov * -1;
        potCambiar = true;
    }

    IEnumerator treureVida()
    {
        yield return new WaitForSeconds(1);
        vida -= 1;
        text.text = "Salut Germana: " + vida;
        vidaSprite.transform.localScale = new Vector2(Mathf.Clamp(1f / vidamax * vida, 0, 1), 0.2f);
        temporitzadorVida = true;
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"  && v.sumarVida == true)
        {
            
            vida +=5;
            text.text = "Salut Germana: " + vida;
            v.sumarVida = false;
            Debug.Log("Hola");
        }

    }
}
