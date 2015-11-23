using UnityEngine;
using System.Collections;

public class FootStepScript : MonoBehaviour {

    [SerializeField]
    AudioClip[] _footSteps;

    [SerializeField]
    AudioSource _audio;

    [SerializeField]
    bool _playNewAudio = false;

    // Use this for initialization
    void Start () {
        _audio = GetComponent<AudioSource>();
    }

    void Update() {
        if (_playNewAudio && !_audio.isPlaying) { 
            _audio.PlayOneShot(_footSteps[Random.Range(0, _footSteps.Length - 1)], _audio.volume);
        }
    }
	
}
