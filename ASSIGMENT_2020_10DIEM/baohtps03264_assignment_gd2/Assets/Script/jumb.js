#pragma strict
static var speed : int = 7;
var animators : Animator;

function Start () {
    animators = GetComponent(Animator);
}

function Update () {
    if(Input.GetKey(KeyCode.UpArrow)){
	Jumb();
    transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);
    }
	if(Input.GetKeyUp(KeyCode.UpArrow)){
	animators.SetBool("jumb", false);
	}
}

function Jumb(){
	animators.SetBool("run", false);
	animators.SetBool("jumb", true);
	}



