#pragma strict

var animator: Animator;
var creep: Transform;
function Start () {
	animator = GetComponent(Animator);

}
function Update () {
	var xCreep = creep.transform.position.x;
	//Debug.Log(x);
	if(xCreep < -8){
		animator.SetBool("Fly", true);
		animator.Play("con qua 2");
	}

}
