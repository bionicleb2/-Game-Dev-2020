﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 30f;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
