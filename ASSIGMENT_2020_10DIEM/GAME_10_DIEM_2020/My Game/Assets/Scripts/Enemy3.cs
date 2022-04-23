using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
        public static int Health = 100;
        public static float healthAmount;
        public bool isDead = false;
        public Animator anim;
   

    void Start()
    {
        healthAmount = 1;
        Health = 100;
        anim = gameObject.GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update () {
        if (Health <= 0)
        {
            isDead = true;
            anim.SetBool("isDead", isDead);
            GameObject.Find("Enemy3").GetComponent<Patrol>().enabled = false; 
            Destroy(gameObject,1f);
        }
    }
 
    void Damage(int damage)
    {
        Health -= damage;
        gameObject.GetComponent<Animation>().Play("enemyFlash");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
        healthAmount -= 0.1f;
        }
    }
}