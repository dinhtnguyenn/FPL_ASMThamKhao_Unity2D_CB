#pragma strict
static var speed : int = 4;
var animator : Animator;

function Start () {
	animator = GetComponent(Animator);
}

function Update () {
	
	if(Input.GetKey(KeyCode.LeftArrow)){
	Run();
	transform.localScale.x = -1.0f;
	transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);
	}
	if(Input.GetKeyUp(KeyCode.LeftArrow)){
	animator.SetBool("run", false);
	}
	if(Input.GetKey(KeyCode.RightArrow)){
	Run();
	transform.localScale.x = 1.0f;
	transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);
	}
	if(Input.GetKeyUp(KeyCode.RightArrow)){
	animator.SetBool("run", false);
	}
}
	function Run(){
	animator.SetBool("run", true);
	}



