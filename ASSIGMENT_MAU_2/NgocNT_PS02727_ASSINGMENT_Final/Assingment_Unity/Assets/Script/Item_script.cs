using UnityEngine;
using System.Collections;

public class Item_script : MonoBehaviour {
	
	void Start () 
	{
		Physics2D.IgnoreLayerCollision (13, 10, true);
		Destroy (this.gameObject, 5);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			if(Main_script.blood < 50)
			{
				Main_script.blood += 5;
			}
			Destroy(transform.root.gameObject);
		}	
	}
}
