using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScroll : MonoBehaviour {

    [SerializeField]
    private float charactersPerSecond;

    [SerializeField]
    private float delay;



    // Use this for initialization
    IEnumerator Start()
    {
        var textBox = GetComponent<Text>();
        string initialText = textBox.text;

        float startTime = Time.time;

        while (true)
        {
            float elapsed = Time.time - startTime;

            int numCharacters = Mathf.FloorToInt(charactersPerSecond * elapsed);

            if (numCharacters >= initialText.Length)
            {
                textBox.text = initialText;
                yield return new WaitForSeconds(delay);
                startTime = Time.time;
            }
            else
            {
                textBox.text = initialText.Substring(0, numCharacters);
            }
            yield return null;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
