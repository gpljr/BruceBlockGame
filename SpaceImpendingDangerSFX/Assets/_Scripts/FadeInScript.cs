using UnityEngine;
using System.Collections;

public class FadeInScript : MonoBehaviour {

    [SerializeField]
    private float _fadeSpeed = 0.001f;

    [SerializeField]
    private bool _fadeOut = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (_fadeOut) {
            GetComponent<Renderer>().material.color += new Color(0, 0, 0, 1f) * _fadeSpeed;
        }
        else { 
            GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 1f) * _fadeSpeed;
        }
	}
}
