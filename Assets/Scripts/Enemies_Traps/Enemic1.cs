using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemic1 : MonoBehaviour
{

    public int maxHealth;
    public int health;
    public float knockbackForce = 100f;

    public PlayerController player;
    public Transform target;

    public float speed = 1f, distance, agroRange;
    public int expPoints, level, damage;

    public SpriteRenderer vida;
    Rigidbody2D rb;
    Animator anim;

    bool moving;

    [SerializeField] private GameObject deathParticle;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        maxHealth = 5 * level;
        health = maxHealth;
        expPoints = 2 * level;
        damage = 5 * level;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < agroRange) 
        {  
            if (Vector2.Distance(transform.position, target.position) > distance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                moving  = true;
                player.canSave = false;
            }
            else
            {
                moving = false;
            }
        }
        else
        {
            moving = false;
        }
        Animations();
    }

    public void takeDamage(int attackDamage)
    {
        vida.enabled = true;
        health -= attackDamage;
        vida.transform.localScale = new Vector2(Mathf.Clamp(1f/maxHealth*health, 0, 1),0.2f);

        if (health <= 0)
        {
            player.UpdateExp(expPoints);
            Instantiate(deathParticle, rb.transform.position, deathParticle.transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.DamagePlayer(damage);
        }
        if (collision.tag == "PlayerBullet")
        {
            takeDamage(player.level * 5);
        }
    }

    void Animations()
    {

        if (moving)
        {
            anim.SetFloat("movX", rb.position.x - player.transform.position.x);
            anim.SetFloat("movY", rb.position.y - player.transform.position.y);
            
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
}
