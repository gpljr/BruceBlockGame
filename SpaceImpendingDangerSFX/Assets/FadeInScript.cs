using UnityEngine;
using System.Collections;

public class FadeInScript : MonoBehaviour {

    [SerializeField]
    private float _fadeSpeed = 0.001f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 1f) * _fadeSpeed;
	}
}
