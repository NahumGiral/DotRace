using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCanvas : MonoBehaviour
{
    Canvas deadCanva;
    // Start is called before the first frame update
    void Start()
    {
        deadCanva = GetComponent<Canvas>();
        deadCanva.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globle.gameover == true && deadCanva.enabled == false)
        {
            deadCanva.enabled = true;
        }
    }
}
