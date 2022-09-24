using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public float jumpForce; // how high we jump when we press the spacebar
    public Rigidbody2D rigidbody; // physics body we want to add force to
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // making our bird jump
        if (Input.GetKeyDown(KeyCode.Space)) // when we press the spacebar
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // add force to our flappy bird to go up
        }
    }
}
