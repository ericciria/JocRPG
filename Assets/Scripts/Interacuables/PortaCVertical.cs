using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaCVertical : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 mov;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.MovePosition(rb.position + mov * Time.deltaTime);
    }
    public void Move()
    {
        mov = new Vector2(0, -2.5f);
        this.enabled = true;
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
