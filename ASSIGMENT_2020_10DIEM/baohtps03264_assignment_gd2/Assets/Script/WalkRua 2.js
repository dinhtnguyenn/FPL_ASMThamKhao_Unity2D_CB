#pragma strict
var animator: Animator;
var x: Transform;
function Start () {
animator = GetComponent(Animator);
}
function Update () {
var x = transform.position.x;
if(x > 18){
	animator.SetBool("Swim", false);
		animator.Play("ca den");
}
}
