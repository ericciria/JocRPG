using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentDona : MonoBehaviour
{
    Animator anim;
    bool potCambiar;
    Rigidbody2D rb;
    Vector2 mov;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        potCambiar = true;
        mov = new Vector2(0, 10);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   

        rb.MovePosition(rb.position + mov * Time.deltaTime);
        
     
        if(potCambiar)
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
    IEnumerator Moure()
    {
        yield return new WaitForSeconds(5);
        mov =mov * -1;
        potCambiar = true;
    }
   
}
