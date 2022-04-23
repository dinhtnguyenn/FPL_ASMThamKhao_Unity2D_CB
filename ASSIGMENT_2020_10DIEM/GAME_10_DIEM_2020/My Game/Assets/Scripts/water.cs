using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private Vector2 startPosition;
    private int speed;

void Start () 
{
    startPosition = transform.position;
    speed = 1;
}

void Update() 
{
    transform.position = 
        new Vector2(startPosition.x + Mathf.Sin(Time.time * speed), transform.position.y);
}
}
