using UnityEngine;

public class characterController : MonoBehaviour
{
    //public GameObject player;
    public AudioSource jumpSound;
    public AudioSource backgroundSound;
    public Rigidbody2D myRigidBody;
    public float jumpForce = 10;
    public LogicScript logic;
    public bool BirdIsAlive= true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {

        // play background music while bird is still flapping its wings, stops music on game over screen
        if(!BirdIsAlive){
            backgroundSound.Play();

        }
        // Checks to see if bird is alive, if not, then cant jump
        if(Input.GetKeyDown(KeyCode.Space) && BirdIsAlive){

            Jump();
            jumpSound.Play();

        }

    }

    void Jump()
    {
        myRigidBody.linearVelocity= Vector2.up *jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        logic.gameOver();
        BirdIsAlive= false;

    }
}
