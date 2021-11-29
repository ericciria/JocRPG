using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroyable : MonoBehaviour {

    public string destroyState;

    Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }

    public void Destruir() 
    {
        anim.Play(destroyState);

        foreach (Collider2D c in GetComponents<Collider2D>())
        {
            c.enabled = false;
        }
    }

    void Update () {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName(destroyState) && stateInfo.normalizedTime >= 1) {
            Destroy(gameObject);
        }
    }
}