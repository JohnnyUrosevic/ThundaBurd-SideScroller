using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
}
