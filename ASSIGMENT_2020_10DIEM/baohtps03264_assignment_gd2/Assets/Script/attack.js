#pragma strict
var animato : Animator;


function Start () {
    animato = GetComponent(Animator);
}

function Update () {
    if(Input.GetKey(KeyCode.Space)){
	Attack();
    }
	if(Input.GetKeyUp(KeyCode.Space)){
	animato.SetBool("attack", false);

	}
}

function Attack(){
	animato.SetBool("attack", true);
	}



