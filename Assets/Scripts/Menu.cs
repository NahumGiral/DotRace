using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void MenuGameButton()
    {
        Globle.RestartValues();
        Globle.isPlaying = false;
        SceneManager.LoadScene("Menu");
    }

}