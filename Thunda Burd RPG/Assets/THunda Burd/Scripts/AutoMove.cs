using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoMove : MonoBehaviour {


	public float speedX;
	public float speedY;

	public bool Horizontal;
	public bool Vertical;

	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Horizontal) {
			rb.AddForce (new Vector2 (speedX, 0f));
		} else if (Vertical) {
			rb.AddForce (new Vector2 (0f, speedY));
		}
		
	}
}
