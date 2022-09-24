using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // slide the pipe to the left
        //transform.position = new Vector3(transform.position.x - speed * Time.time, transform.position.y); // move the thing to the left
    }
}
