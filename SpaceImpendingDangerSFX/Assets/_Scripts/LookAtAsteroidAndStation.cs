using UnityEngine;
using System.Collections;

public class LookAtAsteroidAndStation: MonoBehaviour {

	[SerializeField]
	private Vector3 targetPosition;

	[SerializeField]
	private GameObject asteroid;

	[SerializeField]
	private GameObject station;

	// Use this for initialization
	void Start () {
		LeanTween.move (gameObject, targetPosition, 4f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lookPosition = (asteroid.transform.position*4f + station.transform.position)/5f;
		transform.LookAt (lookPosition, Vector3.up);

		CameraRumble (4f);
	}

	private void CameraRumble(float intensity) {
		Camera.main.transform.localPosition = Random.insideUnitSphere * intensity;
		Camera.main.transform.localRotation = Quaternion.AngleAxis (intensity * 5f, Random.onUnitSphere);
	}
}
