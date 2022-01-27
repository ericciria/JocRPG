using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1_1 : MonoBehaviour
{
    private KeyDoor porta1, porta2;
    private Interactuable lever1,lever2;
    private bool portaActivada;
    private AudioSource sound;

    void Start()
    {
        porta1 = GameObject.Find("/Puzzles/Porta1").GetComponent<KeyDoor>();
        porta2 = GameObject.Find("/Puzzles/Porta2").GetComponent<KeyDoor>();
        lever1 = GameObject.Find("/Puzzles/Lever1").GetComponent<Interactuable>();
        lever2 = GameObject.Find("/Puzzles/Lever2").GetComponent<Interactuable>();

        if (DataPuzzles.l1_p1)
        {
            porta1.Activar();
        }
        if (DataPuzzles.l1_p2)
        {
            porta2.Activar();
        }
    }
    void FixedUpdate(){
        if (lever1.activat && lever2.activat)
        {
            
            porta2.Activar();
        }
    }

    public void Activarp1()
    {
        DataPuzzles.l1_p1 = true;
    }
    public void Activarp2()
    {
        DataPuzzles.l1_p2 = true;
    }
}
