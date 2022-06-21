using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        switch (SceneManager.GetActiveScene().name)
        {
            case "Level_1":
                SceneManager.LoadScene("Level_2_Cutscene");
                break;

            case "Level_2":
                SceneManager.LoadScene("Level_3_Cutscene");
                break;

            case "Level_3":
                SceneManager.LoadScene("Win_Cutscene");
                break;

            default:
               Debug.Log ("You win");
                break;
                
        }
    }
}
