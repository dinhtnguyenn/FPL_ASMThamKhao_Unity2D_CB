using UnityEngine;
using System.Collections;

public class UFO_script : MonoBehaviour {

	public GameObject enemy1, enemy2, enemy3;
	public float time = 1f;

	private Animator anim;
	private int rndNumber;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
		StartCoroutine(startActive());
	}
	
	IEnumerator startActive() {
		anim.SetBool ("ufo_active", true);
		do {
			yield return new WaitForSeconds(time);
			rndNumber = Random.Range (1, 4);
			if(rndNumber == 1)
			{
				Instantiate(enemy1, transform.position, Quaternion.identity);
				//objInstantiate.transform.SetParent(canvas.transform.GetChild (1), false); 
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

}
