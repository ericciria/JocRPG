using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemic2 : MonoBehaviour
{

    public int maxHealth;
    public int health;
    public float knockbackForce = 100f;
    public float fireRate = 1;
    private float fireCooldown;

    public PlayerController player;
    public Transform target;
    public GameObject bullet, bulletParent;

    public float speed = 1f, distance, agroRange;
    public int expPoints, level;

    public SpriteRenderer vida;
    Rigidbody2D rb;
    Animator anim;

    bool moving;

    [SerializeField] private GameObject deathParticle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        maxHealth = 5 * level;
        health = maxHealth;
        expPoints = 2 * level;
        target = GameObject.Find("Player").GetComponent<Transform>();
        //distance = 4;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < agroRange)
        {
            if (Vector2.Distance(transform.position, target.position) > distance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                moving = true;
                player.canSave = false;
            }
            else
            {
                moving = false;
                if(fireCooldown < Time.time)
                {
                    Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
                    fireCooldown = Time.time + fireRate;
                }
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
        vida.transform.localScale = new Vector2(Mathf.Clamp(1f / maxHealth * health, 0, 1), 0.2f);

        if (health <= 0)
        {
            Instantiate(deathParticle, rb.transform.position, deathParticle.transform.rotation);
            player.UpdateExp(expPoints);
            Destroy(gameObject);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            takeDamage(player.level * 5);
        }
    }
}
