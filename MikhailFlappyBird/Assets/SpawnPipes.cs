using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipes; // link to the gameobject we want to spawn
    public float timer; // help us know when to spawn the pipes
    public float boundry; // how high or low can the pipes spawn
    public float spawnTime; // spawn rate for the pipes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= spawnTime)
        {
            float y = Random.Range(-boundry, boundry); // find a new y location
            transform.position = new Vector3(transform.position.x, y); // put our spawner to a new y location
            Instantiate(pipes, transform.position, transform.rotation); // spawn the new pipes
            timer = 0; // reset timer
        }
        timer += Time.deltaTime;
    }
}
