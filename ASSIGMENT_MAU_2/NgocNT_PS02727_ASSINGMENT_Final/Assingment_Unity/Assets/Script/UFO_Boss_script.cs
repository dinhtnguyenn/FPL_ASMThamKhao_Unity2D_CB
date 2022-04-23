using UnityEngine;
using System.Collections;

public class UFO_Boss_script : MonoBehaviour {

	public GameObject enemy1, enemy2, enemy3, goItem;
	public static int bloodBoss = 50;
	private int rndNumber;

	void Start ()
	{
		StartCoroutine(startActive());
		Physics2D.IgnoreLayerCollision (16, 14, false);
	}

	IEnumerator startActive() {
		do {
			yield return new WaitForSeconds(0.75f);
			rndNumber = Random.Range (1, 4);
			if(rndNumber == 1)
			{
				Instantiate(enemy1, transform.position, Quaternion.identity);
			}
			else if (rndNumber == 2)
			{
				Instantiate(enemy2, transform.position, Quaternion.identity);
			}
			else if (rndNumber == 3)
			{
				Instantiate(enemy3, transform.position, Quaternion.identity);
			}			
		} while(true);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{		
		if(other.gameObject.CompareTag("Bullet"))
		{
			int rndNumber = Random.Range (1, 11);
			if(rndNumber == 1)
			{
				Instantiate(goItem, transform.position, Quaternion.identity);
			}

			bloodBoss -= 1;

			if(bloodBoss == 0)
			{
				Score_script.score += 100;
				Destroy(transform.gameObject);
				Application.LoadLevel("splashscreen");
				UFO_Boss_script.bloodBoss = 50;
			}
		}
	}
}