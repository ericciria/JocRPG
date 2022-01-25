using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{

    public int characterLevel;
    public int health;
    public float mana;
    public int exp;

    public float[] position = new float[3];

    public PlayerData(PlayerController player)
    {
        exp = player.exp;
        health = player.health;
        mana = player.mana;
        characterLevel = player.level;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}
