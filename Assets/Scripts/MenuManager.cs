using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void LevelClick1() 
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void LevelClick2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
 
    public void RestartLevelClick() 
    {       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextLevelClick() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ContinueButtonClick() 
    {
        Time.timeScale = 1;
    }
}
