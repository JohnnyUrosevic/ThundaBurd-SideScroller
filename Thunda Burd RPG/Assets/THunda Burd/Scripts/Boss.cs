using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {


    public Rigidbody2D player;

    public float speedX;

    public float hp;

    private bool dead=false;

    [Header("BossManager")]
        public BossManager bossM;    

    [Header("Bullet Settings")]
        public GameObject bulletPrefab;
        public Transform bulletSpawn;
        public float bulletSpeed;
        public float timeStampsB;
        public float bulletCD;

    Rigidbody2D rb;
    Transform trans;
    SpriteRenderer sr;
    Animator anim;



    void Start()
    {
        rb = GetComponent < Rigidbody2D > ();
        trans = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!dead)
        {
            
        }
    }

    private void FixedUpdate()
    {
        if (!dead)
        {
            if (bossM.straight)
            {
                rb.velocity = new Vector2(speedX + player.velocity.x, rb.velocity.y);

            }else
            {
                rb.velocity = new Vector2(0, 0);
            }
            
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Debug.Log(sr.color);
            sr.color = Color.yellow;
            Debug.Log("Direct Hit!!!");
            Destroy(col.gameObject);
            hp -= 1;
            anim.SetInteger("Hp",(int) hp);
        }
    }

    public void fire()
    {
        if (hp > 0)
        {
            if (timeStampsB <= Time.time)
            {
                anim.SetTrigger("shooting");
                // Create the Bullet from the Bullet Prefab
                var bullet = (GameObject)Instantiate(
                                 bulletPrefab,
                                 bulletSpawn.position + new Vector3(0f, 0f, 0f),
                                 bulletSpawn.rotation);

                // Add velocity to the bullet
                 bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed , 0f));

                // Destroy the bullet after 2 seconds
                Destroy(bullet, 2f);

                // CD for bullet
                timeStampsB = Time.time + bulletCD;
            }
        }
    }
}

