using UnityEngine;
using System.Collections;

public class ShakeScreenAndObjects : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            Shake(1f);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shake(float intensity)
    {
        Camera mainCamera = Camera.main;

        Quaternion initialRotation = mainCamera.transform.localRotation;

        LeanTween.value(gameObject, intensity, 0.0f, intensity*2f).setEase(LeanTweenType.easeOutQuad).setOnUpdate((float currentIntensity) =>
        {
            mainCamera.transform.localPosition = Random.insideUnitSphere * currentIntensity;
            mainCamera.transform.localRotation = initialRotation * Quaternion.AngleAxis(currentIntensity * 12f, Random.onUnitSphere);
        });
    }
}
