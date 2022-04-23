#pragma strict
var animator: Animator;
var x: Transform;
function Start () {
animator = GetComponent(Animator);
}
function Update () {
var x = transform.position.x;
if(x < 14){
	animator.SetBool("gach", true);
		animator.Play("gach2");
}
}
