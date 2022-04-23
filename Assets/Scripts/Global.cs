using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globle : MonoBehaviour
{
    public static int velMultiplier = 1;
    public static float velPos = 0.0f;
    public static float velIni = 0.125f;
    public static float score = 0;
    public static int multiplier = 1;
    public static int contadorObs = 0;
    public static bool isAlive = true;
    public static bool gameover = false;
    public static bool isPlaying = false;
    public static void RestartValues()
    {
        velMultiplier = 1;
        velPos = 0.0f;
        velIni = 0.125f;
        score = 0;
        multiplier = 1;
        contadorObs = 0;
        isAlive = true;
        gameover = false;
}

}