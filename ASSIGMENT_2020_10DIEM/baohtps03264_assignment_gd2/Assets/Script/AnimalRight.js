#pragma strict

var animator: Animator;
var creep: Transform;
function Start () {
	animator = GetComponent(Animator);

}
function Update () {
	var xCreep = creep.transform.position.x;
	//Debug.Log(x);
	if(xCreep > 3){
		animator.SetBool("Fly", false);
		animator.Play("con qua");
	}

}
