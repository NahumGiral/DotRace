using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMultiplier : MonoBehaviour
{
    Text scoreMult;
    // Start is called before the first frame update
    void Start()
    {
        scoreMult = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreMult.text = Globle.multiplier.ToString();
        //scoreMult.text = Globle.velMultiplier.ToString();
        //scoreMult.text = Globle.velPos.ToString();
    }
}
