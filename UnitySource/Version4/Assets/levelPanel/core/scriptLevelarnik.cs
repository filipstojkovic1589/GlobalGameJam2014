using UnityEngine;
using System.Collections;

public class scriptLevelarnik : MonoBehaviour {
	
	int lvl = 1;
	public GUISkin skinLevelarnik;
	public GUISkin skinLevelarnik0;
	public GUISkin skinLevelarnik2;
	public GUISkin skinLevelarnik3;
	
	int widthOffset = Screen.width /2 - 450;
	int heightOffset = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		
		GUI.skin = skinLevelarnik0;
		GUI.Box(new Rect(0, -3, Screen.width + 5, Screen.height +5), "");
		GUI.skin = skinLevelarnik;
		GUI.Label(new Rect(widthOffset + 325, 30, Screen.width, 70), "Adventures of R.Y.B.");
		GUI.skin = skinLevelarnik2;
		GUI.Label(new Rect(widthOffset + 385, 90, Screen.width, 70), "RGB Team");
		//lvls
		GUI.Box(new Rect(widthOffset + 205, 165, 500, 420), "");
		
		//frst row
		if(GUI.Button(new Rect(widthOffset + 225, 180,80, 70), "" + lvl))
		{
			Application.LoadLevel("level1");	
			PlayerPrefs.SetString("playerLevel", "level1");
		}
		//ispod ovog skina idu oni koji su zakljucani nivoi

		if(GUI.Button(new Rect(widthOffset + 320, 180, 80, 70), "2")){
			Application.LoadLevel("level2");
			PlayerPrefs.SetString("playerLevel", "level2");
		}
		GUI.skin = skinLevelarnik3;
		GUI.Button(new Rect(widthOffset + 415, 180, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 510, 180, 80, 70), "X");
		 GUI.Button(new Rect(widthOffset + 605, 180, 80, 70), "X");
		
		//scnd row
		GUI.Button(new Rect(widthOffset + 225, 260, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 320, 260, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 415, 260, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 510, 260, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 605, 260, 80, 70), "X");
		//3rd row
		GUI.Button(new Rect(widthOffset + 225, 340, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 320, 340, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 415, 340, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 510, 340, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 605, 340, 80, 70), "X");
		//4 row
		GUI.Button(new Rect(widthOffset + 225, 420, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 320, 420, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 415, 420, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 510, 420, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 605, 420, 80, 70), "X");
		//fift row
		GUI.Button(new Rect(widthOffset + 225, 500, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 320, 500, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 415, 500, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 510, 500, 80, 70), "X");
		GUI.Button(new Rect(widthOffset + 605, 500, 80, 70), "X");
		GUI.Label(new Rect(widthOffset + 400, 600, 200, 200), "GGJ 2014");

	}
}
