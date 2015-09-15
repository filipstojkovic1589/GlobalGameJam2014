using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {
	
	CharacterMotor motor;
	
	// Use this for initialization
	void Start () {
		motor = GameObject.FindGameObjectWithTag("Player").GetComponent("CharacterMotor") as CharacterMotor;
	}
	
	// Update is called once per frame
	void Update () {
		//motor.SetVelocity(new Vector3(1,1,0));
	}
	
	void OnCollisionEnter (Collision col)
	{		
		Debug.Log("Entered.");
    	Destroy(col.collider.gameObject);
    }
		
	void OnCollisionExit (Collision col)
    {
		Debug.Log("Exited.");
		Destroy(col.gameObject);
    }
	
	void OnControllerColliderHit(ControllerColliderHit hit) {
		
		//CharacterMotor motor = (CharacterMotor) hit.gameObject.GetComponent(typeof(CharacterMotor));
		
		/*Debug.Log(hit.moveDirection);
		
		if(motor.grounded){
			if(hit.moveDirection.x == -1){
				motor.wallSliding = true;
				motor.slidingLeft = true;	
			} else if (hit.moveDirection.x == 1){
				motor.wallSliding = true;
				motor.slidingLeft = false;	
			} else {
				motor.wallSliding = false;	
			}
		}
			
		motor.slidingTouchTime = Time.time;*/
		
	}
	
}
