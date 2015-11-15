using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    private Camera mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shake(float intensity)
    {
        Quaternion initialRotation = mainCamera.transform.localRotation;

        LeanTween.value(gameObject, intensity, 0.0f, intensity).setEase(LeanTweenType.easeInOutQuad).setOnUpdate((float currentIntensity) =>
        {
            mainCamera.transform.localPosition = Random.insideUnitSphere * currentIntensity;
            mainCamera.transform.localRotation = initialRotation * Quaternion.AngleAxis(currentIntensity * 5f, Random.onUnitSphere);
        });
    }

    public void Rumble(float intensity)
    {
        LeanTween.value(gameObject, intensity / 10.0f, 0.0f, intensity).setEase(LeanTweenType.easeInQuad).setOnUpdate((float currentIntensity) =>
        {
            mainCamera.transform.localPosition = Random.insideUnitSphere * currentIntensity;
        });
    }
}
