using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayAudio : MonoBehaviour {

	public AudioSource[] pauseAudio;
	public AudioSource[] playAudio;

	public void Audio() {
		for (int i = 0; i < playAudio.Length; i++) {
			playAudio [i].Play ();
		}
	}

	public void AudioPause(){
		for (int i = 0; i < pauseAudio.Length; i++) {
			pauseAudio [i].Pause ();
		}
	}
}
