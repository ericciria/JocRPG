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
        rb.MovePosition(rb.position + mov * speed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.gameObject.tag == "Player")
        {
            distanceX = Mathf.Clamp(this.transform.position.x - col.transform.position.x, -1, 1);
            distanceY = Mathf.Clamp(this.transform.position.y - col.transform.position.y, -1, 1);
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
            speed = 5;
        }
        if (col.gameObject.tag == "Finish")
        {
            Debug.Log("AAAAAAAAAAAAAAA");
            this.enabled = false;
            GameObject porta = GameObject.Find("Porta");
            porta.SetActive(false);
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
