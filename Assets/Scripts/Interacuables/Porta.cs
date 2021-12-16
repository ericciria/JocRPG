using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 mov;
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
        rb = GetComponent<Rigidbody2D>();
        
        mov = new Vector2(0, 0);
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + mov * Time.deltaTime);
    }

    public void Moure()
    {
        this.enabled = true;
        mov = new Vector2(4,0);
        rb.MovePosition(rb.position + mov * Time.deltaTime);
        StartCoroutine(Contador());

    }

    IEnumerator Contador()
    {
        yield return new WaitForSeconds(10);
        this.enabled = false;
        this.gameObject.SetActive(false);
    }
}

