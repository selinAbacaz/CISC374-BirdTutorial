using UnityEngine;

public class CloudsController : MonoBehaviour
{
    // To make clouds move left
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
