﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObsMovement : MonoBehaviour
{
    Vector3 posRef;
    void Awake()
    {
        posRef = new Vector3(0, 10, 0);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -12.5)
        {
            transform.position = transform.position + new Vector3(0, (-1) * Globle.velPos, 0); 
        }
        else
        {
            transform.position = new Vector3(Random.Range(-4.46f, 4.46f), 25.0f, 0);
            //transform.position = new Vector3( 4.46f, 25.0f, 0);
            Globle.contadorObs++;
            if (Globle.contadorObs == 25)
            {
                if (Globle.multiplier < 20)
                {
                    Globle.multiplier++;
                }
                Globle.contadorObs = 0;
            }
        }
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Play");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Globle.RestartValues();
        restartGame();
    }
}
