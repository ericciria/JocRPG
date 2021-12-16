using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    Rigidbody2D rb;
    public bool activat;
    [SerializeField] public GameObject objecte;
    public SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newSprite;



    void Start()
    {
        activat = false;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer= GetComponent<SpriteRenderer>();
    }

    public void Activar()
    {
        ChangeSprite();
        ActivarObjecte();
    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
    public void ActivarObjecte()
    {
        if (!objecte.activeSelf)
        {
            objecte.SetActive(true);
        }
    }
}