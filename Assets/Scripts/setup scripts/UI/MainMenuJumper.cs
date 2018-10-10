
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuJumper : MonoBehaviour {

    public void JumpToMainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }
}
