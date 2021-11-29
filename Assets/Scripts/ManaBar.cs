using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider manaBar;
    public PlayerController playerMana;

    private void Start()
    {
        playerMana = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        manaBar = GetComponent<Slider>();
        manaBar.maxValue = playerMana.maxMana;
        manaBar.value = playerMana.maxMana;
    }

    public void SetMana(float mana)
    {
        manaBar.maxValue = playerMana.maxMana;
        manaBar.value = mana;
    }
}
