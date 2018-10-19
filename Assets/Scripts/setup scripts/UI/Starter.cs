using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour 
{
    public int Scene;
    LoadingSceneController load;
    
    public void StartGame()
    {
       load = FindObjectOfType<LoadingSceneController>();

        load.LoadNextScene(Scene);
    }

    
}
