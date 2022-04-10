using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Intro");
        new WaitForSecondsRealtime(3f);
        SceneManager.LoadSceneAsync("Play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
