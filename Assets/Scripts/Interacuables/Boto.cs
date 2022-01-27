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

    public AudioClip click;
    AudioSource audioSource;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
        objectPressed = false;
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
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
                audioSource.PlayOneShot(click, 0.7F);
            }
            else
            {
                activat = !activat;
                audioSource.PlayOneShot(click, 0.7F);
            }
        }
        else if (!activat){
            activat = true;
            Debug.Log(audioSource);
            audioSource.PlayOneShot(click, 0.7F);
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
        if (col.gameObject.tag == "Box")
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
        if (col.gameObject.tag == "Box")
        {
            Debug.Log("AA");
            objectPressed = false;
            Activar();
        }
    }
}