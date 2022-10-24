using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
namespace Game{

public class Play : MonoBehaviour
{
    public GameObject playcanvass;
    public GameObject maincanvass;
    // Start is called before the first frame update
   public void play(){
    PlayerMovement.alive=true;
    playcanvass.SetActive(false);
    maincanvass.SetActive(true);
   }
   public void restart(){
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     Hit.g=Hit.g*-1;
     Physics.gravity = new Vector3(0,-Hit.g,0);
}
}
}
