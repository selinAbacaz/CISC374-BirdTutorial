using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipesPrefab;
    private float timer = 0;
    public float spawnTime = 2.0f;
    public float heightOffset= 12; 
    void Start()
    {
        spawnPipe();

    }

    // Update is called once per frame
    void Update()
    {

        if(timer < spawnTime){

            timer+= Time.deltaTime;
        }else{
        spawnPipe();
        timer=0.0f;

        }
    }

    void spawnPipe(){

        float lowestPoint= transform.position.y - heightOffset;
        float highestPoint= transform.position.y + heightOffset; 

       Instantiate (pipesPrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);



    }
}

