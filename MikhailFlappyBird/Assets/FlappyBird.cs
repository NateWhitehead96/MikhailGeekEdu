using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // give access to open levels

public class FlappyBird : MonoBehaviour
{
    public float jumpForce; // how high we jump when we press the spacebar
    public Rigidbody2D rigidbody; // physics body we want to add force to
    public int score; // keep track of our score
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
        if(transform.position.x < -12) // when the player gets pushed off screen we lose
        {
            SceneManager.LoadScene(0); // reset or reload the level
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("score"))
        {
            score += 1; // make our score go up by 1 alternatively do score++;
            print(score); // help test
        }
    }
}
