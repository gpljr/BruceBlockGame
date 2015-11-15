using UnityEngine;
using System.Collections;

public class MoveAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LeanTween.moveZ (gameObject, -20f, 6f).setEase(LeanTweenType.easeOutQuad);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
