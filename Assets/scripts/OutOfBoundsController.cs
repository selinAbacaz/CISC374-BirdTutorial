using UnityEngine;

public class OutOfBoundsController : MonoBehaviour
{
    // Stops player from going off screen, kills bird- rip bird
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3){

           logic.gameOver();
        }
        
        

    }
}
