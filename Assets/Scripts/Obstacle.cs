using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
namespace Game {
public class Obstacle : MonoBehaviour {

    PlayerMovement playerMovement;
    public static float health= 100f;
    

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            Destroy(gameObject);
            health = health - 10f;
            if(health == 0){
                playerMovement.canvasdis();
            }
        }
    }
}
}