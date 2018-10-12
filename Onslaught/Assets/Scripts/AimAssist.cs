﻿using UnityEngine;
using System.Collections;

public class AimAssist : MonoBehaviour
{
    public BowBehaviour bBehaviour;
    private Vector3 player_pos;

    void Start()
    {
        bBehaviour = GameObject.Find("Bow").GetComponent<BowBehaviour>();
    }

    void Update()
    {
        if (bBehaviour.aimAssist && !bBehaviour.arrowFired)
        {
            Vector3 mouse_pos = Input.mousePosition;
            player_pos = Camera.main.WorldToScreenPoint(this.transform.position);

            mouse_pos.x = mouse_pos.x - player_pos.x;
            mouse_pos.y = mouse_pos.y - player_pos.y;

            float angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }

    public Vector3 PlayerPos()
    {
        Vector3 pos = player_pos;
        return pos;
    }
}