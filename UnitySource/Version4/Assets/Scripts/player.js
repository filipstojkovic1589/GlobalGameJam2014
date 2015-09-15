var yourMaterial : Material;
var respawnSpot : Transform;

var manager : GameObject;
var player : GameObject;
		
function Awake(){
	manager = GameObject.Find("gameManager");
	player = GameObject.FindGameObjectWithTag("Player");
	PlayerPrefs.SetString("playerColor", "red");
}

function Update () 
{
}

function resetPosition(){
	//transform.parent.gameObject.transform.position = respawnSpot.position;
	Application.LoadLevel(PlayerPrefs.GetString("playerLevel"));;
}

function OnTriggerEnter (other : Collider)
{
	
	if(other.gameObject.tag.Contains("doors")){
		Time.timeScale = 0.3F;
		var fader : GameObject;
		fader = GameObject.FindGameObjectWithTag("fader");
		fader.GetComponent(sceneFadeInOut).sceneEnding = true;
	}


	if(other.gameObject.tag == "key"){
	if(other.gameObject.audio!=null){
			other.gameObject.audio.Play();
		}
		manager.GetComponent(gameManager).doorsUnlocked = true;
		manager.GetComponent(gameManager).unlockDoors();
		Destroy(other.gameObject);
	}
	
	if(other.gameObject.tag == "enemy"){
		//resetPosition();
		//other.gameObject.GetComponent(enemy).resetPosition();
		Application.LoadLevel (0);
	}


	if(other.gameObject.tag == "killerCollider"){
	if(other.gameObject.audio!=null){
			other.gameObject.audio.Play();
		}
		resetPosition();
	}
	
	
	if(other.gameObject.tag.Contains("Buff"))
	{

	
	if(other.gameObject.audio!=null){
			other.gameObject.audio.Play();
		}
	
	
		PlayerPrefs.SetString("playerColor", other.gameObject.tag.Replace("Buff", ""));
		//OVDE SVE BUFFOVE BOJE OSIM POKUPLJENOG, UKLJUCUJEMO KOLAJDER I RENDERER, A SAMO POKUPLJEN DISABLUJEMO
		other.gameObject.renderer.enabled = false;
		other.gameObject.collider.enabled = false;
		
		var buffovi : GameObject[];
		
		buffovi = FindObjectsOfType(GameObject) as GameObject[];

		for (var y=0; y < buffovi.length; y++){
    		if(buffovi[y].tag.Contains("Buff")){
    		if(buffovi[y].tag != other.gameObject.tag){
    		 buffovi[y].renderer.enabled = true;
    		 buffovi[y].collider.enabled = true;
    		 }
    		 }
    	}
		//OVDE KRAJ GORNJEG DELA
		
		
	
		
		respawnSpot.position = other.gameObject.transform.position;
		
		yourMaterial = other.gameObject.renderer.material;
		gameObject.renderer.material = yourMaterial;
		//Destroy(other.gameObject);
		
		var gameObjects : GameObject[];
		
		gameObjects = FindObjectsOfType(GameObject) as GameObject[];

		for (var i=0; i < gameObjects.length; i++){
    		if(gameObjects[i].tag.Contains("Platform")){
    			// hide all platforms except gray ones
    			
    		}
    		
    		  else if (gameObjects[i].tag.Contains("Slider")){
    		  if(!gameObjects[i].tag.Contains("gray")){
    				gameObjects[i].gameObject.collider.enabled = false;		
    			}
    			
    		}
    		
    	}
		
		var ourColorPlatforms : GameObject[];
		
		ourColorPlatforms = FindObjectsOfType(GameObject) as GameObject[];

		for (var z=0; z < ourColorPlatforms.length; z++){
			var blockEffect : TransitionEffect = ourColorPlatforms[z].gameObject.GetComponent(TransitionEffect); 
			var platformTag = ourColorPlatforms[z].tag;
			if(platformTag.Contains(other.gameObject.tag.Replace("Buff", ""))){
				// color is right
				// if it's platform
        		if(platformTag.Contains("Platform")){
        			var text = platformTag.Replace("Platform", "");	
        			if(ourColorPlatforms[z].tag.Contains(text)){
        				if(blockEffect!=null){
        					blockEffect.fadeInFlag = true; 
        				}
            		}
        		}
        		
        		// if it's slider
				else if(platformTag.Contains("Slider")){
					ourColorPlatforms[z].gameObject.collider.enabled = true;
				}
        	} else {
		    	if(!platformTag.Contains("gray")){
		    		if(blockEffect!=null){
		    			if(Vector3.Distance(player.transform.position, ourColorPlatforms[z].gameObject.transform.position)<10){
							blockEffect.fadeOutFlag = true; 
						} else {
							ourColorPlatforms[z].renderer.enabled = false;
        					ourColorPlatforms[z].gameObject.collider.enabled = false;	
						}
					}
				}
        	}
        	
        	
		}
	}
	
	if(other.gameObject.tag == "coin"){
	
	if(other.gameObject.audio!=null){
			other.gameObject.audio.Play();
		}
	
		//gameManager.playerPoints = gameManager.playerPoints+1;
		//other.gameObject.GetComponent(gameManager).resetPosition();
		var cpz = GameObject.FindGameObjectWithTag("coinParticles");
		if(cpz!=null){
			Instantiate(cpz, other.gameObject.transform.position, Quaternion.identity);
		}
		manager.GetComponent(gameManager).playerPoints = manager.GetComponent(gameManager).playerPoints+1;
		other.gameObject.GetComponent(coinScript).killMe = true;
	}
}