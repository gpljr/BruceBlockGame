using UnityEngine;
using System.Collections;

public class RotateAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddTorque(Vector3.forward * .2f, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
