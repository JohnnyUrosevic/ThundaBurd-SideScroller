using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainCamera : MonoBehaviour {

	public GameObject cam;
	public Transform player;
	public float offSetY;
	public float offSetX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 playerPosition = player.position;
		Vector3 newCamPos = new Vector3(playerPosition.x+ offSetX, playerPosition.y+ offSetY, -10);
		cam.transform.position = newCamPos;
		
	}
}
