using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ExitButton() 
    { 
        Application.Quit(); Debug.Log("Game Closed"); 
    } 
    
    public void Play(string sceneName) 
    { 
        SceneManager.LoadScene(sceneName); 
    }

}

