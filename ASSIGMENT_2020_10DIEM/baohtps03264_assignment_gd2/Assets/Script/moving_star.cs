using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_star : MonoBehaviour {
	
	public Animator animator;
    
    public adding add;
	// Use this for initialization
	void Start () {

		add = GameObject.FindWithTag ("point").GetComponent<adding> ();
       
        animator = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}




	void OnTriggerEnter2D(Collider2D col)
	{
        

        animator.SetBool("dichuyen", true);
			
			animator.Play("upto");

			add.UpdateScore ();
            
            StartCoroutine("Wait1second");

			

	}

	IEnumerator Wait1second(){
        gameObject.GetComponentInParent<AudioSource>().Play();
        yield return new WaitForSeconds(1);

		Destroy(gameObject);
        

    }
}
