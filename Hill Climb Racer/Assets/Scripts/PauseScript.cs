using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    bool isPaused = false;
    public Text pausetext;

    public void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            pausetext.text = "Pause";
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            pausetext.text = "Play";
        }
    }

}
