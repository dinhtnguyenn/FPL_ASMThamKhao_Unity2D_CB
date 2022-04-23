using UnityEngine;
using System.Collections;

public class ShootLeft_script : MonoBehaviour {
	public GameObject pSystemShoot;
	public float speed = 18;
	private float scale = 0.4f;

	void Start () 
	{		
		Destroy (this.gameObject, 1.5f);
	}

	void FixedUpdate () 
	{
		gameObject.transform.localScale = new Vector3(-scale, transform.localScale.y, transform.localScale.z);
		gameObject.transform.Translate (Vector3.left * Time.deltaTime * speed);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Ground"))
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
