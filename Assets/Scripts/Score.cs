using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Globle.velPos != 0.0f && Globle.isAlive)
        {
            Globle.score = Globle.score + (0.25f * Globle.multiplier * Globle.velMultiplier);
            scoreText.text = Math.Truncate(Globle.score).ToString();
        }
    }
}
