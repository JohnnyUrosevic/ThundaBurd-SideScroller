using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float startHp;
    public float hp;

    public GameObject HeartFull;
    public GameObject HeartEmpty;

    public PlayerController Player;

    GameObject heart;
    GameObject heartE;

    // Use this for initialization
    void Start() {
        makeHeart(hp);
        
        
    }

    void Update()
    {
        if(hp <= 0)
        {
            Player.gameOver = false;
        }
    }
    public void makeHeart(float numHearts)
    {
        for (int i = 0; i < hp; i++)
        {
            GameObject heart = Instantiate(HeartFull);
            heart.transform.SetParent(transform, false);
        }
    }
    public void deleteHeart(float numHearts)
    {
        hp -= numHearts;
        
            GameObject heartE = Instantiate(HeartEmpty);
            heartE.transform.SetParent(transform, false);
        
       
            GameObject heartD = GameObject.Find("Heart(Clone)");
            Destroy(heartD); 

        
    }
	
    
    
}
