﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart3 : MonoBehaviour {

    Animator animH;
    public Player player;

    // Use this for initialization
    void Start()
    {
        animH = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Animación corazones
        if (player.playerHealth <= 50)
        {
            animH.SetBool("FullHeart", false);
            animH.SetBool("HalfHeart", true);
            animH.SetBool("DeadHeart", false);
        }
        else if (player.playerHealth <= 40)
        {
            animH.SetBool("FullHeart", false);
            animH.SetBool("HalfHeart", false);
            animH.SetBool("DeadHeart", true);
        }
        else if (player.playerHealth > 50)
        {
            animH.SetBool("FullHeart", true);
            animH.SetBool("HalfHeart", false);
            animH.SetBool("DeadHeart", false);
        }
    }
}
