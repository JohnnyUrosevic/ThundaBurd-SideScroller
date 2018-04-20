using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject player;
	public float speed;
	Vector3 position;
	bool moveup;
	bool movedown;
	bool moveleft;
	bool moveright;

	// Use this for initialization
	void Start () {
		moveup = false;
		movedown = false;
		moveleft = false;
		moveright = false;


	}

	// Update is called once per frame
	void FixedUpdate () {

		if (moveup){
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0.0f, speed)*10f);	
		}
		if (movedown){
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0.0f, -1*speed)*10f);
		}
		if (moveleft){
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(-1* speed,0f)*10f);
		}
		if (moveright){
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(speed,0f)*10f);
		}
	}
	public void stopmoveup(){
		moveup=false;
	}
	public void up(){
		moveup=true;
	}
	public void stopmovedown(){
		movedown= false;
	}
	public void down(){
		movedown=true;
	}
	public void stopmoveleft(){
		moveleft=false;
	}
	public void left(){
		moveleft=true;
	}
	public void stopmoveright(){
		moveright=false;
	}
	public void right(){
		moveright=true;
	}
}
