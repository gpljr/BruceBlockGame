using UnityEngine;
using System.Collections;

public class PitchChanger : MonoBehaviour {

    [SerializeField]
    AudioSource _audio;
    [SerializeField]
    AudioClip[] _audioClips;
    float _volume;

	// Use this for initialization
	void Start () {
        _audio = GetComponent<AudioSource>();
        _volume = _audio.volume;
	}
	
	// Update is called once per frame
	void Update () {

        if (_audio.enabled == false)
        {
            _audio.clip = _audioClips[Random.Range(0, _audioClips.Length - 1)];
            _audio.volume = Random.Range(_volume - 0.1f, _volume + 0.1f);
        }
        
	}
}
