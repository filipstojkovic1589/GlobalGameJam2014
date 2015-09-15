var target : Transform; //the enemy's target
var moveSpeed = 2; //move speed
var rotationSpeed = 2; //speed of turning
 
var myTransform : Transform; //current transform data of this enemy
 
var respawnSpot : Transform;
 
function Awake()
{
    myTransform = transform; //cache transform data for easy access/preformance
}
 
function Start()
{
     target = GameObject.FindWithTag("Player").transform; //target the player
 
}
 
function Update () {
    //rotate to look at the player
    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
    Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
 
    //move towards the player
    myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
 
 
}

function resetPosition(){
	transform.gameObject.transform.position = respawnSpot.position;
}