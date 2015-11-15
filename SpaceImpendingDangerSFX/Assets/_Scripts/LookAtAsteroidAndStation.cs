using UnityEngine;
using System.Collections;

public class LookAtAsteroidAndStation: MonoBehaviour {

	[SerializeField]
	private Transform asteroid;
	[SerializeField]
	private Transform station;

	[SerializeField]
	private Camera camera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 centerPoint = (asteroid.position + station.position) / 2f;

		transform.LookAt (centerPoint, Vector3.up);

		float distance = (transform.position - centerPoint).magnitude;

		float rumbleIntensity = Mathf.Max(0f, 1f / distance - 0.05f) / 5f;
		if (rumbleIntensity > 0f) {
			CameraRumble (rumbleIntensity);
		}

	}

	private void CameraRumble(float intensity) {
		camera.transform.localPosition = Random.insideUnitSphere * intensity;
		camera.transform.localRotation = Quaternion.AngleAxis (intensity * 5f, Random.onUnitSphere);
	}
}
