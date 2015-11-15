using UnityEngine;
using System.Collections;

public class PlayerFollowCamera : MonoBehaviour {

    [SerializeField]
    private GameObject _player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = _player.transform.position + Vector3.up * 1.5f;
	}
}
