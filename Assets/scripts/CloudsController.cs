using UnityEngine;

public class CloudsController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed= 5;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ( Vector3.left* moveSpeed) * Time.deltaTime;

    }
}
