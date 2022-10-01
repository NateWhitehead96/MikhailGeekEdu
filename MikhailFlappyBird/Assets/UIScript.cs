using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // access to UI

public class UIScript : MonoBehaviour
{
    public Text scoreText; // display what our score is
    public FlappyBird bird; // to get the score number
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = bird.score.ToString(); // display whatever our score is
    }
}
