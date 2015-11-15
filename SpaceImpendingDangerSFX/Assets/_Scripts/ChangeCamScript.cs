using UnityEngine;
using System.Collections;

public class ChangeCamScript : MonoBehaviour {

    [SerializeField]
    private GameObject _newOnCamera;
    [SerializeField]
    private GameObject _newOffCamera;

	// Use this for initialization
	void Start () {
        _newOnCamera.SetActive(true);
        _newOffCamera.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
