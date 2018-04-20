using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundprefs : MonoBehaviour {
	
	public Slider volumehethong;

	void Awake()
	{
		AudioListener.volume= PlayerPrefs.GetFloat("volume");
		volumehethong.value= AudioListener.volume;
		volumehethong.onValueChanged.AddListener(setvolume); //this!! delegate  into setvolume void below.
	}


	public void setvolume(float volumecontrol)
	{
		AudioListener.volume= volumecontrol;

		PlayerPrefs.SetFloat("volume",volumecontrol);
	}

}﻿
