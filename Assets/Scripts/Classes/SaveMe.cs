using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveMe : MonoBehaviour
{
    public int Scene;
    public LoadingSceneController LoadingScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LoadingScene = FindObjectOfType<LoadingSceneController>();

            LoadingScene.LoadNextScene(Scene);
        }
    }
}
