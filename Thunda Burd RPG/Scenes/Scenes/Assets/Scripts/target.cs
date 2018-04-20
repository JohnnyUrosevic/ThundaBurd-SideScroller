using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour {
	public Transform firstTarget;
	public float step;
	public float speed;
	bool moveright;


	// Use this for initialization
	void Start () {
		moveright = false;
		step = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (moveright) {

				transform.position = Vector3.MoveTowards (transform.position, firstTarget.position, step);

			}
		}
	
}
	public void goRight(){
		moveright = true;
	}
}
