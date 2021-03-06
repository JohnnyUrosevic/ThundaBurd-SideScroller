using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour {
	public Slider slider;
	public AudioSource audio;

	void Awake(){
		if (slider) {
			audio.volume = PlayerPrefs.GetFloat ("Curvol");
			slider.value = audio.volume;
		}
		audio.volume = PlayerPrefs.GetFloat ("CurVol");
		slider.value = audio.volume;
	}

	public void ChangeScene (string sceneName){
		Application.LoadLevel (sceneName);
	}
	public void LoadScene(string loadName){
		Application.LoadLevel (loadName);
	}
	public void VolumeControl(float volumeControl){
		audio.volume = volumeControl;
		PlayerPrefs.SetFloat ("CurVol", audio.volume);
	}



}



