using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
    public void ResetGameButton()
    {
        Globle.RestartValues();
        Globle.isPlaying = true;
        SceneManager.LoadScene("Play");
    }

}
