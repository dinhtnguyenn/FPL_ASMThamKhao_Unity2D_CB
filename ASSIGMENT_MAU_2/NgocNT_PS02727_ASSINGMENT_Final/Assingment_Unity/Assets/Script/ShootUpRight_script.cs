using UnityEngine;
using System.Collections;

public class ShootUpRight_script : MonoBehaviour {
	public GameObject pSystemShoot;
	public float speed = 18;
	
	void Start () 
	{		
		Destroy (this.gameObject, 1.5f);
	}
	
	void FixedUpdate () 
	{
		gameObject.transform.localScale = new Vector3(0.4f, transform.localScale.y, transform.localScale.z);
		transform.localRotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 45f);
		gameObject.transform.Translate (Vector3.right * Time.deltaTime * speed);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Boss") || other.gameObject.CompareTag("Enemy"))
		{
			Destroy(this.transform.root.gameObject);
			Instantiate(pSystemShoot, transform.position, Quaternion.identity);
		}
		else if(other.gameObject.CompareTag("Boss") || other.gameObject.CompareTag("Enemy"))
		{
			Instantiate(pSystemShoot, transform.position, Quaternion.identity);
		}
	}
}
