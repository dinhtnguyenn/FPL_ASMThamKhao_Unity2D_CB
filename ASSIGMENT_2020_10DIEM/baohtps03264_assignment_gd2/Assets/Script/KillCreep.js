#pragma strict

function Start () {
}
function Update () {
}
function OnTriggerEnter2D(collider : Collider2D)
 {
     if(collider.tag == "attack")
     {   
		 gameObject.Find("OngCong2").GetComponent.<AudioSource>().Play();
		
         Destroy(gameObject);	 
     }
 }