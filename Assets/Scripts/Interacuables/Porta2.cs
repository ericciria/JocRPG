using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta2 : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    [SerializeField] Palanca palanca1, palanca2, palanca3, palanca4;
    [SerializeField] Sprite sprite2;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (palanca1.activat)
        {
            if (!palanca2.activat)
            {
                if (palanca3.activat)
                {
                    if (palanca4.activat)
                    {
                        palanca1.bloquejat = true;
                        palanca2.bloquejat = true;
                        palanca3.bloquejat = true;
                        palanca4.bloquejat = true;
                        bc = this.GetComponent<BoxCollider2D>();
                        bc.enabled = false;
                        spriteRenderer.sprite = sprite2;
                    }
                }
            }
        }
    }
}
