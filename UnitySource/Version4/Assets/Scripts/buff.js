#pragma strict

function Start () {

}

function Update () {
	transform.Rotate(6.0*10*Time.deltaTime,6.0*10*Time.deltaTime,0);
}