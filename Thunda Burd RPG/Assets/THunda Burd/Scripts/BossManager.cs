using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour {


    public float timer;

    [Header("Movement")]
        public float goingS;
        public bool straight = false;

    [Header("Shield Settings")]
    public bool shield = true;

    [Header("ShootingSetting")]
    public bool shooting = false;


   
	
	// Update is called once per frame
	void Update () {
		while(timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer == goingS)
            {
                straight = true;
            }
        }
    }
}
