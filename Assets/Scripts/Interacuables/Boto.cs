using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boto : MonoBehaviour
{
    public bool activat;
    [SerializeField] public GameObject objecte;
    public SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;



    void Start()
    {
        activat = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite2;
    }

    public void Activar()
    {
        ChangeSprite();
        ActivarObjecte();
    }

    public void ChangeSprite()
    {
        if (activat)
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1;
        }
        
    }
    public void ActivarObjecte()
    {
        activat = !activat;
        objecte.SetActive(activat);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ActivarObjecte();
            ChangeSprite();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ActivarObjecte();
            ChangeSprite();
        }
    }
}