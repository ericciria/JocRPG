using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empenyable : MonoBehaviour
{
    float distanceX;
    float distanceY;
    Vector2 mov;
    Rigidbody2D rb;
    private float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mov = new Vector2(
            distanceX,
            distanceY
        );
        

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.gameObject.tag == "Player")
        {
            

            distanceX = Input.GetAxisRaw("Horizontal");
            distanceY = Input.GetAxisRaw("Vertical");
            Debug.Log("distanceX: " + distanceX);
            Debug.Log("distanceY: " + distanceY);
            if (distanceX == 1 || distanceX == -1)
            {
                distanceY = 0;
            }
            else
            {
                distanceX = 0;
            }
            speed = 2;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            distanceX = 0;
            distanceY = 0;
            speed = 0;
        }
    }
}
