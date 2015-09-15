using UnityEngine;
using System.Collections;

public class TransitionEffect : MonoBehaviour {
	
	public bool fadeInFlag = false;
	public bool fadeOutFlag = false;
	
	private int scaleCounter, scaleEffectLength;
	private Vector3 scaleVect, scaleVectFadeOut, initialScale;
	
	// Use this for initialization
	void Start () {
		scaleCounter = 0;
		scaleEffectLength = 10;
		scaleVect = new Vector3(15f/scaleEffectLength, 15f/scaleEffectLength, 0);
		scaleVectFadeOut = new Vector3(transform.localScale.x/(5*scaleEffectLength), transform.localScale.y/(5*scaleEffectLength), 0f);
		initialScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(fadeInFlag){
			if(fadeOutFlag){
				fadeOutFlag = false;
				transform.localScale = initialScale;
				scaleCounter = 0;
			}
			if(scaleCounter==0){
				transform.localScale += new Vector3(15f, 15f, 0f);
				renderer.enabled = true;
			}
			if(scaleCounter<scaleEffectLength){
				transform.localScale -= scaleVect;
				//renderer.material.color.a = (float)(scaleCounter*255/scaleEffectLength);
				scaleCounter++;
			} else {
				gameObject.collider.enabled = true;	
				fadeInFlag = false;
			}
		} else if(fadeOutFlag){
			if(scaleCounter==0){
				//transform.localScale += new Vector3(10f, 10f, 10f);
				//scaleVect = new Vector3(1f/scaleEffectLength, 1f/scaleEffectLength, 1f/scaleEffectLength);
			}
			if(scaleCounter<scaleEffectLength*5){
				transform.localScale -= scaleVectFadeOut;
				scaleCounter++;
			} else {
				transform.localScale = initialScale;
				gameObject.collider.enabled = false;
				renderer.enabled = false;
				fadeOutFlag = false;
			}
		} else {
			scaleCounter = 0;
		}
	}
	
}
