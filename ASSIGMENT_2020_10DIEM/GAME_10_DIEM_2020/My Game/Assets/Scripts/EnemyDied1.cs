﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDied1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (Enemy1.Health <= 0){
            gameObject.GetComponent<BoxCollider2D> ().enabled = false;
        }

        
    }
}
