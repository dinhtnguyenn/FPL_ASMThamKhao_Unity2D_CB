using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
        public static int Health = 175;
        public static float healthAmount;
        public bool isDead = false;
        public Animator anim;
   
    void Start()
    {
         healthAmount = 1;
         Health = 175;
         anim = gameObject.GetComponent<Animator>();
   
    }
    // Update is called once per frame
    void Update () {
        if (Health <= 0)
        {
            isDead = true;
            anim.SetBool("isDead", isDead);
            GameObject.Find("Boss").GetComponent<Patrol>().enabled = false; 
            Destroy(gameObject,1f);
            //gameObject.tag = "Ground";           
        }
    }
 
    void Damage(int damage)
    {
        Health -= damage;
        gameObject.GetComponent<Animation>().Play("bossFlash");
    
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
        healthAmount -= 0.1f;
        }
    }
}