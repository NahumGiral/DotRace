using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadFound : MonoBehaviour
{
    SpriteRenderer fondoMuerte;
    // Start is called before the first frame update
    void Start()
    {
        fondoMuerte = GetComponent<SpriteRenderer>();
        fondoMuerte.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globle.gameover == true && fondoMuerte.enabled == false)
        {
            fondoMuerte.enabled = true;
        }
    }
}
