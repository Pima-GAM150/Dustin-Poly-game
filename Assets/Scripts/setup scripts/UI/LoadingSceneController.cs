using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneController : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBar;
    AsyncOperation async;

    Animator transition;

    public void LoadNextScene(int LVL)
    {
        StartCoroutine(LoadingScreenRoutine(LVL));

    }

    IEnumerator LoadingScreenRoutine(int lvl)
    {
        LoadingScreen.SetActive(true);
        async = SceneManager.LoadSceneAsync(lvl);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            LoadingBar.fillAmount = async.progress;

            if (async.progress == 0.9f)
            {
                LoadingBar.fillAmount = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }


}
