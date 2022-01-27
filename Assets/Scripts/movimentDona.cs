using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentDona : MonoBehaviour
{
    [SerializeField] Text text;
    Animator anim;
    bool potCambiar;
    Rigidbody2D rb;
    Vector2 mov;
    private PlayerController player;
    ContadorVidaGermana contadorVida;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        potCambiar = true;
        mov = new Vector2(0, 2);
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
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
        yield return new WaitForSeconds(3);
        mov =mov * -1;
        potCambiar = true;
    }
}
