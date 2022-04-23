using UnityEngine;
using System.Collections;

public class Main_script : MonoBehaviour {

	public GameObject bulletRight;
	public GameObject bulletLeft;
	public GameObject bulletUpRight;
	public GameObject bulletUpLeft;
	public int speed = 2;
	public static Animator anim;
	public static int blood = 30;

	private Transform go;
	private float scale = 0.6f;
	private bool flagRight = true;
	
	void Start () 
	{	
		go = gameObject.transform;
		anim = GetComponent<Animator> ();
		Physics2D.IgnoreLayerCollision (9, 10, true);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.D))
		{
			flagRight = true;
			anim.SetBool("run_shoot", true);
			go.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);
			go.Translate(new Vector2(4, 0) * Time.deltaTime * speed);

			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Instantiate(bulletRight, transform.position, Quaternion.identity);
			}
		}
		else if(Input.GetKey(KeyCode.A))
		{
			flagRight = false;
			anim.SetBool("run_shoot", true);
			go.localScale = new Vector3(-scale, transform.localScale.y, transform.localScale.z);
			go.Translate(new Vector2(-4, 0) * Time.deltaTime * speed);

			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Instantiate(bulletLeft, transform.position, Quaternion.identity);
			}
		}
		else if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			if (Input.GetKey (KeyCode.W)) 
			{
				StartCoroutine(topShooting());
			}
			else
			{
				StartCoroutine(Shooting());
			}
		} 

		if (Input.GetKey (KeyCode.Space)) {
			go.Translate (new Vector2 (0, 8) * Time.deltaTime * speed);
		}

		if(Input.GetKeyUp(KeyCode.D))
		{
			anim.SetBool("run_shoot", false);
		}

		if(Input.GetKeyUp(KeyCode.A))
		{
			anim.SetBool("run_shoot", false);
		}
	}

	IEnumerator OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Boss") || other.gameObject.CompareTag("KillMan"))
		{
			if(blood >= 5)
			{
				blood -= 5;
			}

			if(blood <= 0)
			{
				Physics2D.IgnoreLayerCollision(9, 15, true);
				anim.SetBool("dead", true);
				yield return new WaitForSeconds(1f);
				Destroy(transform.gameObject);
				Application.LoadLevel("splashscreen");
				Physics2D.IgnoreLayerCollision(9, 15, false);
				Main_script.blood = 30;
				UFO_Boss_script.bloodBoss = 50;
				Score_script.score = 0;
			}		
		}
	}

	private IEnumerator Shooting()
	{
		anim.SetBool("shoot", true);
		yield return new WaitForSeconds(0.2f);
		if(flagRight)
		{
			Instantiate(bulletRight, transform.position, Quaternion.identity);
		}
		else
		{
			Instantiate(bulletLeft, transform.position, Quaternion.identity);
		}
		anim.SetBool("shoot", false);
	}

	private IEnumerator topShooting()
	{
		anim.SetBool("shoot", true);
		yield return new WaitForSeconds(0.2f);
		if(flagRight)
		{
			Instantiate(bulletUpRight, transform.position, Quaternion.identity);
		}
		else
		{
			Instantiate(bulletUpLeft, transform.position, Quaternion.identity);
		}
		anim.SetBool("shoot", false);
	}
}
