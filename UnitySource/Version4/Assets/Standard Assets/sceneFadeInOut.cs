using UnityEngine;
using System.Collections;

public class sceneFadeInOut : MonoBehaviour {
	
	public float fadeSpeed = 4.0f;
	
	private bool sceneStarting = true;
	public bool sceneEnding = false;
	// Use this for initialization
	void Awake(){
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(sceneStarting){
			StartScene();
		}
		if(sceneEnding){
			EndScene();
		}
	}
	
	void FadeToClear ()
    {
        // Lerp the colour of the texture between itself and transparent.
        guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed/4 * Time.deltaTime);
    }
    
    
    void FadeToBlack ()
    {
        // Lerp the colour of the texture between itself and black.
        guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
    }
	
	void StartScene(){
		FadeToClear();
		
		if(guiTexture.color.a <= 0.05f){
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			sceneStarting = false;
		}
	}
	
	public void EndScene(){
		guiTexture.enabled = true;
		FadeToBlack();
		
		if(guiTexture.color.a >= 0.6f){
			Time.timeScale = 1;
			Application.LoadLevel("levelPanel");	
		}
	}
}
