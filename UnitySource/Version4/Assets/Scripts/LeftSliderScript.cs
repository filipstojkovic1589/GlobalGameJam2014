using UnityEngine;
using System.Collections;

public class LeftSliderScript : MonoBehaviour {

	CharacterMotor motor;
	
	// Use this for initialization
	void Start () {
		motor = GameObject.FindGameObjectWithTag("Player").GetComponent("CharacterMotor") as CharacterMotor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col){
		if (Input.GetKeyDown ("space")){
			motor.SetVelocity(new Vector3(12,10,0));	
		}
	}
	
	void OnTriggerStay(Collider col){
		if (Input.GetKeyDown ("space")){
			motor.SetVelocity(new Vector3(12,10,0));	
		}
	}
	
}
