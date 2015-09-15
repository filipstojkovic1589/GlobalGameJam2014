#pragma strict

var playerPoints = 0;
var doorsUnlocked = false;

function Start () {
	resetLevel();
}

function Update () {

}

function OnGUI () {
	GUI.Label (Rect (10, 10, 100, 20), "You have: " + playerPoints + " points.");
}

function unlockDoors(){
	var gameObjects : GameObject[];
	gameObjects = FindObjectsOfType(GameObject) as GameObject[];
 
    for (var i=0; i < gameObjects.length; i++){
        if(gameObjects[i].tag.Contains("doors")){
            gameObjects[i].renderer.enabled = true;
            gameObjects[i].gameObject.collider.enabled = true;
        }
    }
}

function resetLevel(){
	var gameObjects : GameObject[];
			
	gameObjects = FindObjectsOfType(GameObject) as GameObject[];
 
    for (var i=0; i < gameObjects.length; i++){
        if(gameObjects[i].tag.Contains("Platform")){
            gameObjects[i].renderer.enabled = false;
            gameObjects[i].gameObject.collider.enabled = false;
        }
    }
    
    for (var object : GameObject in GameObject.FindGameObjectsWithTag("redPlatform")){
		object.renderer.enabled = true;
		object.gameObject.collider.enabled = true;
	}
	for (var object : GameObject in GameObject.FindGameObjectsWithTag("grayPlatform")){
		object.renderer.enabled = true;
		object.gameObject.collider.enabled = true;
	}
}