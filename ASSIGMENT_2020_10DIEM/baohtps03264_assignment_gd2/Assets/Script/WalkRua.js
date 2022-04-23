#pragma strict
var animator: Animator;
var x: Transform;
function Start () {
animator = GetComponent(Animator);
}
function Update () {
var x = transform.position.x;
if(x < 15){
	animator.SetBool("Swim", true);
		animator.Play("ca den 2");
}
}
