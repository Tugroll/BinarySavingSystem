using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public string health;
    public float healthbar;

    public PlayerData(GameControl gamecontrol)
    {
        health = gamecontrol.healthcount.text;
        healthbar = gamecontrol.HealthBar.fillAmount;
    }
}
