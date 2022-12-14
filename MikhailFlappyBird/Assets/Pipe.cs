using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public int speed; // how fast the pipe moves
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // slide the pipe to the left
        if(transform.position.x < -12) // when it goes off screen
        {
            Destroy(gameObject); // destroy the pipes
        }
    }
}
