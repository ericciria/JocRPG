using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2_1 : MonoBehaviour
{
    private KeyDoor porta1, porta2, porta3, portaF;
    [SerializeField] PortaCVertical verticalDoor;
    [SerializeField] Boto button1,button2,button3,button4;
    [SerializeField] Boto button5, button6, button7, button8;
    [SerializeField] Boto button9, button10, button11, button12, button13, button14, button15, button16, button17;
    [SerializeField] Empenyable box1, box2, box3, box4;

    private bool startGateMovement = false;
    private Vector2 posBox1, posBox2, posBox3, posBox4;



    void Start()
    {
        porta1 = GameObject.Find("/Puzzles/Porta1").GetComponent<KeyDoor>();
        porta2 = GameObject.Find("/Puzzles/Porta2").GetComponent<KeyDoor>();
        porta3 = GameObject.Find("/Puzzles/Porta3").GetComponent<KeyDoor>();
        portaF = GameObject.Find("/Puzzles/PortaFinal").GetComponent<KeyDoor>();

        posBox1 = GameObject.Find("Box1").GetComponent<Transform>().position;
        posBox2 = GameObject.Find("Box2").GetComponent<Transform>().position;
        posBox3 = GameObject.Find("Box3").GetComponent<Transform>().position;
        posBox4 = GameObject.Find("Box4").GetComponent<Transform>().position;

        Debug.Log(DataPuzzles.l2_p1);
        if (DataPuzzles.l2_p1)
        {
            porta1.Activar();
        }
        if (DataPuzzles.l2_p2)
        {
            porta2.Activar();
        }
        if (DataPuzzles.l2_p3)
        {
            porta3.Activar();
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
    public void Activarp3()
    {
        DataPuzzles.l2_p3 = true;
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
        if (button9.activat)
        {
            if (button10.activat)
            {
                if (button11.activat)
                {
                    if (button12.activat)
                    {
                        if (button13.activat)
                        {
                            if (button14.activat)
                            {
                                if (button15.activat)
                                {
                                    if (button16.activat)
                                    {
                                        if (button17.activat)
                                        {
                                            porta3.Activar();
                                        }
                                    }
                                }
                            }
                        }
                    }
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
    public void ResetButtons2()
    {
        GameObject.Find("Box1").GetComponent<Transform>().position = posBox1;
        GameObject.Find("Box2").GetComponent<Transform>().position = posBox2;
        GameObject.Find("Box3").GetComponent<Transform>().position = posBox3;
        GameObject.Find("Box4").GetComponent<Transform>().position = posBox4;
        if (button13 != null)
        {
            button13.activat = false;
            button13.ChangeSprite();
        }
        if (button14 != null)
        {
            button14.activat = false;
            button14.ChangeSprite();
        }
        if (button15 != null)
        {
            button15.activat = false;
            button15.ChangeSprite();
        }
        if (button16 != null)
        {
            button16.activat = false;
            button16.ChangeSprite();
        }
        if (button17 != null)
        {
            button17.activat = false;
            button17.ChangeSprite();
        }
    }

}
