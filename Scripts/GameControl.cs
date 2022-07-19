using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Image HealthBar;
    public Text healthcount;
    string counted;

    public void IncreaseHealth()
    {
        HealthBar.fillAmount += .01f;
        healthcount.text = ((int)(HealthBar.fillAmount * 100)).ToString();
    }
    public void DecreaseHealth()
    {
        HealthBar.fillAmount -= .01f;
        healthcount.text = ((int)(HealthBar.fillAmount * 100)).ToString();
        counted = healthcount.text;
    }


    public void Save()
    {
        SavingSystem.Saveplayer(this);
    }

    public void Loading()
    {
        PlayerData data = SavingSystem.LoadPlayer();

        HealthBar.fillAmount = data.healthbar;
        counted = data.health.ToString();
        healthcount.text = counted;

    }


}
