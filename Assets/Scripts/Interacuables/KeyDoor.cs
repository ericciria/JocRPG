using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyDoor: MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    [SerializeField] Sprite sprite2;
    Puzzle2_1 puzzle;

    public bool activat;
    public UnityEvent myEvent;  // faig l'event per poder activar una funció diferent per cada porta i poder reutilitzar el script,
                                // ja que guardo la informació en una classe estatica perque es mantingui entre escenes.

    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        // Ho fico en l'Awake perque sinó peta quan en Puzzle2_1 faig Activar()
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        puzzle = gameObject.GetComponentInParent<Puzzle2_1>();
        activat = false;
    }

    public void Activar()
    {
        
        bc = this.GetComponent<BoxCollider2D>();
        bc.enabled = false;
        spriteRenderer.sprite = sprite2;
        activat = true;
        myEvent.Invoke();   // Activo la funció que li assigno desde el inspector
    }
}
