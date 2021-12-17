using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyFollowPlayer : MonoBehaviour


{
    [SerializeField] private string sceneName;
    public int vidas = 4;
    public float speed;
    private Transform player;
    public float lineOfSite;
    public float shootRange;
    public GameObject bullet;
    public GameObject bulletParent;
    public float fireRate = 1;
    private float NextFireTime;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null) { return; }
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > shootRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
            //anim.SetBool("run", true);
        }
        else if (distanceFromPlayer <= shootRange && NextFireTime < Time.time)
        {
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            NextFireTime = Time.time + fireRate;
            //anim.SetBool("run", false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootRange);
    }

  
      
    }
  

