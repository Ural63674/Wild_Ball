using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    private int levelNumber;
    public Text levelNumberText;
   
    public void PauseClick() 
    {
        levelNumber = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(levelNumber);
        levelNumberText.text = levelNumber.ToString();
        Time.timeScale = 0;
    }

    public void MainMenuClick() 
    {
        SceneManager.LoadScene(0);
    }
}
