using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlertFlash : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        var image = GetComponent<Image>();
        while (true)
        {
            image.enabled = true;
            yield return new WaitForSeconds(0.4f);
            image.enabled = false;
            yield return new WaitForSeconds(0.2f);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
