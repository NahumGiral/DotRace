using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EndCameraScore : MonoBehaviour
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
        if (Globle.gameover==true && scoreText.enabled==false)
        {
            scoreText.text = Math.Truncate(Globle.score).ToString();
            scoreText.enabled = true;
        }
    }
}
