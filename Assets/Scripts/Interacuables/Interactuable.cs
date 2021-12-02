using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    Rigidbody2D rb;
    public bool activat;
    [SerializeField] public GameObject objecte;

    // Start is called before the first frame update
    void Start()
    {
        activat = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
