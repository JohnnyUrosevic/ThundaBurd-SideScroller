using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerSpawn : MonoBehaviour {

    public Boss boss;

    public GameObject platform;
    public Transform spawnPoint;
    public float distanceBetween;

    private float platfromWidth;
    public GameObject player;

	// Use this for initialization
	void Start () {
        platfromWidth = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
      
        if(transform.position.x < spawnPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platfromWidth + distanceBetween, transform.position.y, 0f);

            Instantiate(platform, transform.position, transform.rotation);

        }

	}


}
