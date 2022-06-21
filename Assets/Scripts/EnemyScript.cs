using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    GameObject player;
    public string currentScene;
    private void Start()
    {
        player = GameObject.Find("Player");
        currentScene = SceneManager.GetActiveScene().name;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            
            SceneManager.LoadScene("Game_Over");
        }
       
    }
}
