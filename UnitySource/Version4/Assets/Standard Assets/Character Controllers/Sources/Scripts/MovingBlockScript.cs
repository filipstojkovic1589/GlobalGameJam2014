using UnityEngine;
using System.Collections;

public class MovingBlockScript : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float coef = Mathf.Sin(Time.time*3);
		transform.Translate(Vector3.down*coef/10);
	}
}
