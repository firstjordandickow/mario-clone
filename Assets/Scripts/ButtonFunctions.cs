using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public void  Restart()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    public void Continue()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case ("Level_1_Cutscene"):
                SceneManager.LoadScene("Level_1");
                break;
            case ("Level_2_Cutscene"):
                SceneManager.LoadScene("Level_2");
                break;
            case ("Level_3_Cutscene"):
                SceneManager.LoadScene("Level_3");
                break;
        }
       
    }


}
