using UnityEngine;
using System.Collections;

public class EnemyRight_script : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{	
		Physics2D.IgnoreLayerCollision (15, 10, true);
		Physics2D.IgnoreLayerCollision (15, 12, true);
		Physics2D.IgnoreLayerCollision (15, 13, true);
		Physics2D.IgnoreLayerCollision (15, 15, true);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player") && Main_script.blood > 0)
		{
			Destroy(this.transform.root.gameObject);
		}
	}
}
