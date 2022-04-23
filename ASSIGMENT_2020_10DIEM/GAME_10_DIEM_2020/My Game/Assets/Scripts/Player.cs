using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Player : MonoBehaviour {
 
    public float speed = 50f, maxspeed = 30, maxjump = 4, jumpPow = 250f;
    public bool grounded = true, faceright = true, doublejump = false;
 
    public int ourHealth;
    public int maxhealth = 3;
 
    public Rigidbody2D r2;
    public Animator anim;
    public gamemaster gm;

    public int Levelload = 2;

    public SoundManager sound;

    public GameObject leftKunai, rightKunai;
    Transform firePos;
    public float attackdelay = 0.3f;
    public bool attacking = false;
 
    // Use this for initialization
    void Start () {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
        ourHealth = maxhealth;
        sound = GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>();
        firePos = transform.Find("firePos");

    }
   
    // Update is called once per frame
    void Update () {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
 
        if (Input.GetKeyDown(KeyCode.Space)){
            if (grounded)
            {
                grounded = false;
                doublejump = true;
                r2.AddForce(Vector2.up * jumpPow);
            }
 
            else
            {
                if (doublejump)
                {
                    doublejump = false;
                    r2.velocity = new Vector2(r2.velocity.x, 0);
                    r2.AddForce(Vector2.up * jumpPow * 0.7f);
 
                }
            } 
        }

        if (Input.GetKeyDown(KeyCode.X) && !attacking){
            attacking = true;
            attackdelay = 0.3f;

            Fire();
        }

        if (attacking) {
            if (attackdelay > 0){
                 attackdelay -= Time.deltaTime;
            }else{
                attacking = false;
            }
        }
    }
 
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);
 
        if (r2.velocity.x > maxspeed)
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        if (r2.velocity.x < -maxspeed)
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
 
        if (r2.velocity.y > maxjump)
            r2.velocity = new Vector2(r2.velocity.x, maxjump);
        if (r2.velocity.y < -maxjump)
            r2.velocity = new Vector2(r2.velocity.x, -maxjump);
 
 
 
        if (h>0 && !faceright)
        {
            Flip();
        }
 
        if (h < 0 && faceright)
        {
            Flip();
        }
 
        if (grounded)
        {
            r2.velocity = new Vector2(r2.velocity.x * 0.7f, r2.velocity.y);
        }
 
        if (ourHealth <= 0)
        {
            Death();
        }
    }
 
    public void Flip()
    {
        faceright = !faceright;
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
 
    public void Death()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(3);
    }
   
    public void Damage(int damage)
    {
        ourHealth -= damage;
        gameObject.GetComponent<Animation>().Play("RedFlash");
    }
 
    public void Knockback (float Knockpow, Vector2 Knockdir)
    {
        r2.velocity = new Vector2(0, 0);
        if (faceright){
        r2.AddForce(new Vector2(Knockdir.x * -50, Knockdir.y + Knockpow));
        }
        if (!faceright){
        r2.AddForce(new Vector2(Knockdir.x * 50, Knockdir.y + Knockpow));
        }
    }
 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            sound.Playsound("coins");
            Destroy(col.gameObject);
            gm.points += 1;
        }

        if (col.CompareTag("Key"))
        {
            Destroy(col.gameObject);
            gm.key = 1;
        }
    }

    void Fire(){
        if (faceright){
            Instantiate(rightKunai, firePos.position, Quaternion.identity);
        }

        if (!faceright){
            Instantiate(leftKunai, firePos.position, Quaternion.identity);
        }
    }

}