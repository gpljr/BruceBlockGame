using UnityEngine;
using System.Collections;

public class MoveAsteroidToStation : MonoBehaviour {

	[SerializeField]
	private Transform station;

	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private GameObject explosionPrefab;

	private float cameraShakeIntensity;

	// Use this for initialization
	void Start () {
		cameraShakeIntensity = .03f;

		LeanTween.move (gameObject, station.position + offset, 4f).setEase(LeanTweenType.easeInQuad).setOnComplete(() => {

			Instantiate(explosionPrefab, transform.position, Quaternion.identity);
			LeanTween.value(gameObject, 4f, 0f, 2f).setOnUpdate((float valu) => cameraShakeIntensity = valu).setEase(LeanTweenType.easeOutCirc);
		});
	}
	
	// Update is called once per frame
	void LateUpdate () {
		CameraRumble (cameraShakeIntensity);
	}

	private void CameraRumble(float intensity) {
		Camera.main.transform.localPosition = Random.insideUnitSphere * intensity;
		Camera.main.transform.localRotation = Quaternion.AngleAxis (intensity * 5f, Random.onUnitSphere);
	}


}
