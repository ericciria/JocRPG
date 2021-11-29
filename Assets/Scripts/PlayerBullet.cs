using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    PlayerController player;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Vector2 moveDir = ( player.attackHitboxPos.transform.position - player.transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Object")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
