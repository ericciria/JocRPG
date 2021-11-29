using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject target;
    PlayerController player;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        player = target.GetComponent<PlayerController>();
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
        //Destroy(this.gameObject, 3);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
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