#pragma strict

var killMe : boolean =  false;

function Start () {

}

function Update () {
	if(killMe){
		destroyYourself();
	}
}

function destroyYourself(){
	transform.Translate(-17f * Time.deltaTime, 15f * Time.deltaTime, 0); 
	yield WaitForSeconds(3);
   	Destroy(gameObject);
}