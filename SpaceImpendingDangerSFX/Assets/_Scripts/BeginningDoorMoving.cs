using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BeginningDoorMoving : MonoBehaviour {
	bool beginMoving;
	float speed=1f;
	 float x,y,z;
    //public Image _image;

    [SerializeField]
    KeyCode _press;

	// Use this for initialization
	void Start () {
			x=transform.position.x;
			 y=transform.position.y;
			 z= transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(_press))
		{
			beginMoving=true;
			
		}
		if(beginMoving)
		{
			transform.localPosition+=new Vector3 (Time.deltaTime * speed ,0,0);
			//StartCoroutine(Fade(0.4f,false));
		}
	}

	 // IEnumerator Fade (float timerDuration, bool fadeIn) {
  //       Color startColor = _image.color;
  //       Color newColor;
  //       float alpha;
  //       float timer = 0f;

  //       while (timer < timerDuration) {
  //           timer += Time.deltaTime;
  //           if (fadeIn) {
  //               alpha = 1f - (timer / timerDuration);
  //           } else {
  //               alpha = (timer / timerDuration);
  //           }
  //           newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
  //           _image.color = newColor;
  //           yield return null;
  //       }
  //       if (fadeIn) {
  //           alpha = 0;
  //       } else {
  //           alpha = 1;
  //       }
  //       newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
  //       _image.color = newColor;
  //   }
}
