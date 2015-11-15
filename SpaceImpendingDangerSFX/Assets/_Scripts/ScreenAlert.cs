using UnityEngine;
using System.Collections;

public class ScreenAlert : MonoBehaviour {
	//public Material alertMat;
	public Texture alertTex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
		{
			gameObject.GetComponent<Renderer>().materials[1].mainTexture = alertTex;
		}
	}
}
