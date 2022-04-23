using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D r2;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        r2.velocity  = speed;
    }

    // Update is called once per frame
    void Update()
    {
        r2.velocity = speed;
        Destroy(gameObject, delay);
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
