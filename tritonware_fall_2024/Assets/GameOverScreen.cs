using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    
  public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }  
    public void RestartGame(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    } 
}
