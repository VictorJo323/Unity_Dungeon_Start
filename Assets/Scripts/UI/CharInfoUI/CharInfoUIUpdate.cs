using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CharInfoUIUpdate : MonoBehaviour
{

    public TextMeshProUGUI health;
    public TextMeshProUGUI atk;
    public TextMeshProUGUI def;
    public TextMeshProUGUI critRate;
    public TextMeshProUGUI lev;
    public TextMeshProUGUI gold;
    public TextMeshProUGUI charDescription;

    public StatData playerStats;
    // Start is called before the first frame update

    void Start()
    {
        UpdateStatsUI();
    }

    private void UpdateStatsUI()
    {
        if (playerStats != null)
        {
            health.text = playerStats.maxHealth.ToString();
            atk.text = playerStats.baseAttack.ToString();
            def.text = playerStats.baseDefence.ToString();
            critRate.text = playerStats.critRate.ToString();
            lev.text = playerStats.level.ToString();
            gold.text = playerStats.curGold.ToString();
            charDescription.text = playerStats.charDescription.ToString();
        }
    }
}
