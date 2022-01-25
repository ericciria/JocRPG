using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapArrow : MonoBehaviour
{

    public GameObject bullet, bulletParent;
    private float fireCooldown;
    public float fireRate;

    void Start()
    {
        fireRate = Random.Range(0.7f, 1.3f);
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
