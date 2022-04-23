using UnityEngine;
using System.Collections;

public class AlienSlug_script : MonoBehaviour {
	public GameObject goItem;
	public GameObject pSystemAlienSlug;
	public float speed = 3;

	private float scale = 0.3f;
	private bool flag;
	private Transform go;
	
	void Start () 
	{
		Destroy (this.gameObject, 10);
		go = gameObject.transform;
	}

	void Update () 
	{
		if (flag) 
		{
			go.localScale = new Vector3(-scale, transform.localScale.y, transform.localScale.z);
			go.Translate (new Vector3(-5, 0, 0) * Time.deltaTime * speed);
		}
		else
		{
			go.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);
			go.Translate (new Vector3(5, 0, 0) * Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if(flag)
		{
			flag = false;
		}
		else 
		{
			flag = true;
		}

		if(other.gameObject.CompareTag("Bullet"))
		{
			int rndNumber = Random.Range (1, 11);
			if(rndNumber == 1 || rndNumber == 2)
			{
				Instantiate(goItem, transform.position, Quaternion.identity);
			}
			Score_script.score += 1;
			Destroy(other.transform.root.gameObject);
			Destroy(transform.root.gameObject);
			Instantiate(pSystemAlienSlug, transform.position, Quaternion.identity);
		}
	}
}
