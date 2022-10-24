using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
namespace Game {
public class GameManager : MonoBehaviour {

    public static int score;
    int distance;
    public static GameManager inst;

    [SerializeField] Text scoreText;
    [SerializeField] Text distanceText;
    

    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore ()
    {
        
    }

    private void Awake ()
    {
        inst = this;
    }

    private void Start () {
        playerMovement.playerdistance = 0 ;
	}

	private void Update () {
        
        scoreText.text = "SCORE: " + score;
        distanceText.text = "Distance :" + Mathf.FloorToInt(playerMovement.playerdistance);

	}
}
}