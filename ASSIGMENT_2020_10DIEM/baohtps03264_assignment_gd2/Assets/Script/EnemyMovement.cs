using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float enemySpeed;

	Rigidbody2D enemyBody;
	

	public GameObject enemyGraphic;

	bool turnRight = true;
	float turnTime = 5f;
	float nextFlip = 0f;
	bool canFlip = true;

	void Awake(){
		enemyBody = GetComponent<Rigidbody2D> ();
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextFlip){
			nextFlip = Time.time + turnTime;
			flip();
		}
		if (enemyGraphic == null) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			if(turnRight && other.transform.position.x < transform.position.x){
				flip();
			}else if(!turnRight && other.transform.position.x > transform.position.x){
				flip();
			}
			canFlip = false;
		}

	}

	void OnTriggerStay2D (Collider2D other){
		if (other.tag == "Player") {
			if(!turnRight){
				enemyBody.AddForce(new Vector2(-1,0)*enemySpeed);
			}else {
				enemyBody.AddForce(new Vector2(1,0)*enemySpeed);
			}
			
		}
		
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.tag == "Player") {
			canFlip = true;
		}
		enemyBody.velocity = new Vector2 (0, 0);
		
	}

	void flip(){
		if (!canFlip) {
			return;
		}
		turnRight = !turnRight;
		Vector3 theScale = enemyGraphic.transform.localScale;
		theScale.x *= -1;
		enemyGraphic.transform.localScale = theScale;
	}
}
