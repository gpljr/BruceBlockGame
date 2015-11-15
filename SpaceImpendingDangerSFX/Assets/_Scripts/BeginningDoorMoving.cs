using UnityEngine;
using System.Collections;

public class BeginningDoorMoving : MonoBehaviour {
	bool beginMoving;
	float speed=1f;
	 float x,y,z;
	// Use this for initialization
	void Start () {
			x=transform.position.x;
			 y=transform.position.y;
			 z= transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.O))
		{
			beginMoving=true;
			
		}
		if(beginMoving)
		{
			print("moving");
			transform.position+=new Vector3 (Time.deltaTime * speed ,0,0);
		}
	}
}
