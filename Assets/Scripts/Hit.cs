using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
namespace Game
{

public class Hit : MonoBehaviour
{

    public int a1 = -90;
    public int a2 = -90;

    public GameObject alignment1;
    public GameObject alignment2;
    public int axis1 = 50;
    public int axis2 = -50;
    public static  float g = 10;
    public float speed = 20.0f;
    public Slider slider;
    public Text healthtext;
    public Animator down ;
    
    void  Start() {
        Physics.gravity = new Vector3 (0,-g,0);
        
        GameManager.score = 0;
     
    }

    public  void OnTriggerEnter(Collider other) {
   

    if(other.CompareTag("Platform")){
        transform.rotation= new Quaternion(0f,0f,0f,0f);
        GameManager.score= GameManager.score+1000;
        
       
    }
    if(other.CompareTag("PlatformInv")){
        transform.rotation= new Quaternion(0f,0f,-90f,0f);
        GameManager.score= GameManager.score+1000;
        
        
    }
    
    

 }
  private void Update() {
       Debug.Log(g);
    
       if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.DORotate(new Vector3(0,0,a1),1.0f,RotateMode.WorldAxisAdd);
                 transform.RotateAround(alignment1.transform.position,new Vector3(0,axis1,0),speed);
                  g=g*-1;
                  Physics.gravity = new Vector3(0,-g,0);
                  axis1 = axis1*-1;
                
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.DORotate(new Vector3(0,0,-a2),1.0f,RotateMode.WorldAxisAdd);
                transform.RotateAround(alignment2.transform.position,new Vector3(0,axis2,0),speed);
                g=g*-1;
                Physics.gravity = new Vector3(0,-g,0);
                axis2 = axis2*-1;
                
            }
            slider.value = Obstacle.health;
            healthtext.text = "Health :" + Obstacle.health ;
      
 }
}
}

