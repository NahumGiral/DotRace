using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadText : MonoBehaviour
{
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globle.gameover == true && scoreText.enabled == false)
        { 
            scoreText.enabled = true;
        }
    }
}
