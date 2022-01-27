using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2_1 : MonoBehaviour
{
    private KeyDoor porta1, porta2, portaF;
    [SerializeField] PortaCVertical verticalDoor;
    [SerializeField] Boto button1,button2,button3,button4;
    [SerializeField] Boto button5, button6, button7, button8;

    private bool startGateMovement = false;



    void Start()
    {
        porta1 = GameObject.Find("/Puzzles/Porta1").GetComponent<KeyDoor>();
        porta2 = GameObject.Find("/Puzzles/Porta2").GetComponent<KeyDoor>();
        portaF = GameObject.Find("/Puzzles/PortaFinal").GetComponent<KeyDoor>();
        Debug.Log(DataPuzzles.l2_p1);
        if (DataPuzzles.l2_p1)
        {
            porta1.Activar();
        }
        if (DataPuzzles.l2_p2)
        {
            porta2.Activar();
        }
        if (DataPuzzles.l2_pF)
        {
            portaF.Activar();
        }
    }

    public void Activarp1()
    {
        DataPuzzles.l2_p1 = true;
    }
    public void Activarp2()
    {
        DataPuzzles.l2_p2 = true;
    }
    public void ActivarpF()
    {
        DataPuzzles.l2_pF = true;
    }

    private void FixedUpdate()
    {
        if (!startGateMovement)
        {
            if (button1.activat && button2.activat && button3.activat && button4.activat && !button5.activat && !button6.activat && !button7.activat && !button8.activat)
            {
                if (verticalDoor != null)
                {
                    verticalDoor.Move();
                    startGateMovement = true;
                }
            }
        }
    }
    public void ResetButtons()
    {
        if (button1 != null)
        {
            button1.activat = false;
            button1.ChangeSprite();
        }
        if (button2 != null)
        {
            button2.activat = false;
            button2.ChangeSprite();
        }
        if (button3 != null)
        {
            button3.activat = false;
            button3.ChangeSprite();
        }
        if (button4 != null)
        {
            button4.activat = false;
            button4.ChangeSprite();
        }
        if (button5 != null)
        {
            button5.activat = false;
            button5.ChangeSprite();
        }
        if (button6 != null)
        {
            button6.activat = false;
            button6.ChangeSprite();
        }
        if (button7 != null)
        {
            button7.activat = false;
            button7.ChangeSprite();
        }
        if (button8 != null)
        {
            button8.activat = false;
            button8.ChangeSprite();
        }
    }

}
