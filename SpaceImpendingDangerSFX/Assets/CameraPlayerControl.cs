using UnityEngine;
using System.Collections;

public class CameraPlayerControl : MonoBehaviour {

    [SerializeField]
    private float _rotationSpeed;

    [SerializeField]
    private float _scalingValue;

    // Max limits to clamp Y axis
    float yMinLimit = -20f;
    float yMaxLimit = 80f;

    // Variables for rotation
    float xRotate = 0f;
    float yRotate = 0f;
    float zRotate = 0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ManageRotation();
        ManageScaling();
	}

    void ManageRotation() {
        xRotate = Input.GetAxis("Mouse X") * _rotationSpeed;
        yRotate = Input.GetAxis("Mouse Y") * _rotationSpeed;
        zRotate = Input.GetAxis("Mouse X") * _rotationSpeed;

        yRotate = ClampAngle(yRotate, yMinLimit, yMaxLimit);

        transform.localEulerAngles += new Vector3(-yRotate, 0f, 0f);

        transform.localEulerAngles += new Vector3(0f, xRotate, 0f);
    }

    // This function will clamp the angles on the Y axis
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }

    public void ManageScaling()
    {

        float Scale;
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {

            Scale = Input.GetAxis("Mouse ScrollWheel") * _scalingValue;
            if (transform.localScale.x <= 1 && Scale > 0) {
                Scale = 0;
            }
            else if (transform.localScale.x >= 10 && Scale < 0) {
                Scale = 0;
            }
            else {
                Scale = Input.GetAxis("Mouse ScrollWheel") * _scalingValue;
            }

            transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale + new Vector3(1f, 1f, 1f) * -Scale, Time.deltaTime);
        }
    }
}
