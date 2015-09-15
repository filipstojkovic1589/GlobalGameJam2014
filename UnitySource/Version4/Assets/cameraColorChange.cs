using UnityEngine;
using System.Collections;

public class cameraColorChange : MonoBehaviour {

	 Color yellow = new Color(0.15f, 0.15f, 0.1f, 1);
	 Color blue = new Color(0, 0, .1f ,255 );
	 Color red = new Color(0.1f, 0, 0 ,255	);
	void Update() {
		float yellowR = Random.Range(-50, 50);
		float yellowB = Random.Range(-50, 50);
		//yellow = new Color(150 + yellowR,150 + yellowB,  0, 0);
		if(PlayerPrefs.GetString("playerColor") == "yellow"){
			camera.backgroundColor = yellow;

		}
		if(PlayerPrefs.GetString("playerColor") == "blue"){
			camera.backgroundColor = blue;
			
		}
		if(PlayerPrefs.GetString("playerColor") == "red"){
			camera.backgroundColor = red;
			
		}

	}

}
