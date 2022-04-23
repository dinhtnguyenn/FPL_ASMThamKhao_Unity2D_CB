using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUN : MonoBehaviour {

	// Use this for initialization
	

	public Animator animator;
    public Collider2D attackTrigger;
	void Start () {
		animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update(){


		if(Input.GetKeyDown(KeyCode.Space)){

            attackTrigger.enabled = true;
            			
		}
        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            attackTrigger.enabled = false;
        }
    }  
}
