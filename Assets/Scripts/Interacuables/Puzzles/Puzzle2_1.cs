using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2_1 : MonoBehaviour
{
    private KeyDoor porta1;
    // Start is called before the first frame update
    void Start()
    {
        porta1 = GameObject.Find("/Puzzles/Porta1").GetComponent<KeyDoor>();
        if (DataPuzzles.l2_p1)
        {
            porta1.Activar();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activarp1()
    {
        DataPuzzles.l2_p1 = true;
    }

}
