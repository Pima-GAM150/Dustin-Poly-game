
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuJumper : MonoBehaviour {

    LoadingSceneController Load;

    public void JumpToMainMenu()
    {
        Load = FindObjectOfType<LoadingSceneController>();

        Load.LoadNextScene(0);
    }
}
