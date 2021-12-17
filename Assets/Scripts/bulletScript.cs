using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{


    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;

    // Start is called before the first frame update
    void Start()
    {

        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moverDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moverDir.x, moverDir.y);
      

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
