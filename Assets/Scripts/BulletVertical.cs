using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVertical : MonoBehaviour
{
    PlayerController player;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
        Vector2 moveDir = new Vector2(0,-1 * speed);
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
        //Destroy(this.gameObject, 3);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Object")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            player.DamagePlayer(5);
            Destroy(gameObject);
        }
    }
}
