using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    Rigidbody2D rb;
    public bool activat, bloquejat;
    [SerializeField] GameObject objecte;
    [SerializeField] Sprite sprite1, sprite2;
    private SpriteRenderer spriteRenderer;



    void Start()
    {
        activat = false;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Activar()
    {
        if (!bloquejat)
        {
            ChangeSprite();
            ActivarObjecte();
        }
    }

    public void ChangeSprite()
    {
        if (activat)
        {
            spriteRenderer.sprite = sprite1;
            activat = false;
        }
        else
        {
            spriteRenderer.sprite = sprite2;
            activat = true;
        }
        
    }
    public void ActivarObjecte()
    {
        if (objecte != null)
        {
            objecte.SetActive(activat);
        }
    }
}
