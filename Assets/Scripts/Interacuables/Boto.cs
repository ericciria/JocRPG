using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boto : MonoBehaviour
{
    public bool activat;
    [SerializeField] public GameObject objecte;
    public SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] bool intermitent;
    bool objectPressed;
    public UnityEvent myEvent;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
        objectPressed = false;
        //Debug.Log(spriteRenderer.sprite);
    }

    public void Activar()
    {
        ActivarObjecte();
        ChangeSprite();
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
        if (intermitent)
        {
            myEvent.Invoke();
            if (objectPressed)
            {
                activat = true;
            }
            else
            {
                activat = !activat;
            }
        }
        else
        {
            activat = true;
        }
        if (objecte != null)
        {
            objecte.SetActive(activat);
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Activar();
        }
        if (col.gameObject.tag == "Object")
        {
            Debug.Log("A");
            objectPressed = true;
            Activar();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            activat = true;
            Activar();
        }
        if (col.gameObject.tag == "Object")
        {
            Debug.Log("AA");
            objectPressed = false;
            Activar();
        }
    }
}