﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortify : PassiveSpell {
    
    PlayerController pController;
    PlayerStats pStats;

    private void Start()
    {
        pController = GameObject.Find("Archer").GetComponent<PlayerController>();
        pStats = GameObject.Find("Archer").GetComponent<PlayerStats>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("ApplySpell", 0.0f);
        }
    }

    public void ApplySpell()
    {
        pStats.maxHealth += spellLevel * amount;
        if(pStats.curHealth < pStats.maxHealth)
        {
            pStats.curHealth += spellLevel * amount;
            if (pStats.curHealth >= pStats.maxHealth)
            {
                pStats.curHealth = pStats.maxHealth;
            }
        }
    }

}
