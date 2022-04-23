using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimeDamage : MonoBehaviour {
	
	public float pushPlayer;
	float nextDamage;
	//Am thanh khi nhan vat bi thuong

	// Use this for initialization
	void Start () {
		nextDamage = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player" && nextDamage < Time.time) {
			
			push(other.transform);
		}
	}

	void push(Transform trans){
		//khi dung trung vat the lat vi tri nhan vat - tri vi trung phai
		Vector2 pushDirecY = new Vector2 (0, (trans.position.y - transform.position.y)).normalized;
		pushDirecY *= pushPlayer;
		Rigidbody2D pusgRB = trans.gameObject.GetComponent<Rigidbody2D> ();
		pusgRB.velocity = Vector2.zero;
		pusgRB.AddForce (pushDirecY,ForceMode2D.Impulse);
	}
}
