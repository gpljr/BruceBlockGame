using UnityEngine;
using System.Collections;

public class ScreenAlert : MonoBehaviour {
	//public Material alertMat;
	public Texture alertTex;
	public Color alertColor;
	Color blackColor;
	bool alert;
	bool flashOn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
		{
			gameObject.GetComponent<Renderer>().materials[1].mainTexture = alertTex;
			alert = true;
			gameObject.GetComponent<Renderer>().materials[1].color = alertColor;
			
		}
		if(alert && !flashOn)
		{
			StartCoroutine(FlashOn());
		}
		if(alert && flashOn)
		{
			StartCoroutine(FlashOff());
		}
	}
	IEnumerator FlashOn(){
		
		
		yield return new WaitForSeconds(0.2f);
		gameObject.GetComponent<Renderer>().materials[1].color = alertColor;
			flashOn=true;
	}
	IEnumerator FlashOff(){
		
		
		yield return new WaitForSeconds(0.2f);
		gameObject.GetComponent<Renderer>().materials[1].color = blackColor;
			flashOn=false;
	}
}
