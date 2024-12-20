﻿using UnityEngine;
using System.Collections;

public class PressureZone : MonoBehaviour {

    private PlayerManager player;
    public uint nextLayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerManager>())
        {
            if (!player)
            {
                player = other.GetComponent<PlayerManager>();
            }

            if(player.GetNumOfCarbons() > 0)
            {
                GameManager.art.SwitchLayer(nextLayer);
            }
        }
    }
}
