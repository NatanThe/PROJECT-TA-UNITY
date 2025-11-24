using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Scene Change
    public void Change(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
