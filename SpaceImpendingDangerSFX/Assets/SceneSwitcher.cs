using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space)) {
            Application.LoadLevel(Application.loadedLevel + 1);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
	}
}
