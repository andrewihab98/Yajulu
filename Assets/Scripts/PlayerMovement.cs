using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
namespace Game
{
    

public class PlayerMovement : MonoBehaviour {

    public static bool alive = false;
    public float jumpAmount = 35;

    public float speed = 5;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    public float playerdistance = 0;
    [SerializeField] float horizontalMultiplier = 10;
    public Animator down ;
    public  GameObject canvass;
     private void Start() {
        down = GetComponent<Animator>();
    }
    private void FixedUpdate ()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        playerdistance = playerdistance+ 30*Time.deltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        
    }

    private void Update () {
        horizontalInput = Input.GetAxis("Horizontal");

      
         if (transform.position.y < -30.1 && transform.position.y >-30.9) {
            Obstacle.health= Obstacle.health - 1f;
            
        }
        if (transform.position.y < -60.1 && transform.position.y >-60.9) {
            Obstacle.health= Obstacle.health - 1f;
            
        }
         if (transform.position.y < -100.1 && transform.position.y >-100.9) {
            Obstacle.health= Obstacle.health - 1f;
            
        }
        if (transform.position.y < -140.1 && transform.position.y >-140.9) {
            Obstacle.health= Obstacle.health - 1f;
            
        }
         if (transform.position.y <-200) {
            Obstacle.health= 0;
            if(Obstacle.health == 0){
                canvasdis();
                
            }
        }
        if (transform.position.y < -3 && transform.position.y >-8) {
             down.Play("IsJumping");
             
        }
        if (transform.position.y <0 && transform.position.y >-1) {
             down.Play("IsJumping");
        }
        
        
	}
    public void canvasdis(){
        canvass.SetActive(true);
        alive = false;
        playerdistance = 0;
    }
    public void Die ()
    {
        alive = false;
        // Restart the game
        Invoke("Restart",0);
        Obstacle.health=100;
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
}
