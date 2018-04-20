using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    [Header("Speed Settings")]
        public float speedX;
        public float speedY;
        public float speedBall;

    [Header("Bullet Settings")]
        public GameObject bulletPrefab;
        public Transform bulletSpawn;
        public float bulletSpeed;
        private float timeStampsB;
        public float bulletCD;

    [Header("Health Scripts")]
        public Health healthScript;

    float speed;

    [Header("GameOver Scenes")]
        public bool gameOver = true;
        public GameObject gameOverC;
        public GameObject nGameOverC;
        private bool win = false;
        public GameObject winC;

// Use this for initialization
//Don't listen to the comment above ^

	Rigidbody2D rb;
	Animator anim;
    


    void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();

        
        

    }

	// Update is called once per frame
	void Update () {
        int t = 10;
        if (gameOver)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                jump();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fire();
            }

            speed = rb.velocity.x;

            anim.SetInteger("speed", (int)speed);

            anim.SetInteger("jumpSpeed", (int)rb.velocity.y);
            
        }else
        {

            anim.SetInteger("Hp", 0);
            gameOverC.SetActive(true);
            nGameOverC.SetActive(false);
          
        }if (win)
        {
            winC.SetActive(true);
            nGameOverC.SetActive(false);
        }
       
	} 
		
	//Poggers

	void FixedUpdate (){
        if (gameOver)
            rb.AddForce(new Vector2(speedX, 0));
            
	}

	public void jump(){
        if (gameOver)
        {
            if (rb.velocity.y == 0){
				rb.AddForce (new Vector2(0f, speedY));
			}
        }
    }

	public void fire(){
		if(gameOver)
        {
            if (timeStampsB <= Time.time) {
				anim.SetTrigger ("shooting");
				// Create the Bullet from the Bullet Prefab
				var bullet = (GameObject)Instantiate (
					             bulletPrefab,
					             bulletSpawn.position + new Vector3 (1f, 0f, 0f),
					             bulletSpawn.rotation);
				
				// Add velocity to the bullet
			bullet.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (bulletSpeed + rb.velocity.x, 0f));
			
				// Destroy the bullet after 2 seconds
				Destroy (bullet, 2f);
				timeStampsB = Time.time + bulletCD;
		}
        }
    }

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.tag == "DogHead" && !win) {
            healthScript.deleteHeart(healthScript.hp);
           
		}if (col.tag == "Enemy" && !win)
        {
            healthScript.deleteHeart(1);
        }
        if (col.tag == "Speed Ball") {
			Debug.Log ("you did it");
			rb.AddForce(new Vector2(speedBall, 0f));
		}
        if (col.tag == "Fall" && !win)
        {
            gameOver = false;
        }
        if (col.tag == "Win")
        {
            win = true;
        }
	}

   
//found jimmie

}

