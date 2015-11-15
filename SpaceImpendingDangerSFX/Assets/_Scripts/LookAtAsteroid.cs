using UnityEngine;
using System.Collections;

public class LookAtAsteroid : MonoBehaviour {

	[SerializeField]
	private Transform asteroid;

	[SerializeField]
	private Camera camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (asteroid, Vector3.up);

		float distance = (transform.position - asteroid.transform.position).magnitude;

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
