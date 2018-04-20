using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBall : MonoBehaviour {

	public GameObject PurpleOrb;

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			PurpleOrb.SetActive(false);

		}
	}
}
