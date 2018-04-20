using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public float speed;
	public Transform player;

	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 trans = new Vector2 (player.position.x, player.position.y);
		rb.MovePosition(Vector2.Lerp(transform.position, player.position, Time.deltaTime *speed));
	}
}
