using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapArrow : MonoBehaviour
{

    public GameObject bullet, bulletParent;
    private float fireCooldown;
    public float fireRate = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (fireCooldown < Time.time)
        {
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            fireCooldown = Time.time + fireRate;
        }
    }
}
