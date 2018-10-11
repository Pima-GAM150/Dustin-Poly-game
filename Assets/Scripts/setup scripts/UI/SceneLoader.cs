using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour, IFadeComplete
{
    public Animator AnimationControler;
    public int Seconds;

    public int nscene;
    public bool Ending;
    public bool MainMenu;
    public bool LoadingScene;

    void Start()
    {
        nscene = 0;
        Ending = false;
        MainMenu = true;
        LoadingScene = false;
    }
        
    IEnumerator FadeOut(int seconds)
    {
        while(true)
        {
            yield return new WaitForSeconds(seconds);

            AnimationControler.SetTrigger("FadeOut");

            AnimationControler.ResetTrigger("FadeOut");

            AnimationControler.SetTrigger("NewScene");

            AnimationControler.ResetTrigger("NewScene");

            LoadNextScene();
        }
    }

    void IFadeComplete.OnFadeComplete()
    {
        StartCoroutine(FadeOut(Seconds));
    }

    public void LoadNextScene()
    {
        if(MainMenu)
        {
            SceneManager.LoadScene(3);
            MainMenu = false;
            LoadingScene = true;
            Ending = false;
            Seconds = 11;
        }
        else if(Ending)
        {
            SceneManager.LoadScene(5);
            Ending = false;
            
        }
        else if(LoadingScene)
        {
            SceneManager.LoadScene(4);
            LoadingScene = false;
            Seconds = 1;
            
        }
        else
        {
            SceneManager.LoadScene(nscene);

            nscene++;

            if(nscene > 2)
            {
                Ending = true;
                nscene = 0;
            }
            
        }
    }
    public void SetMainMenu()
    {
        MainMenu = true;
        LoadingScene = false;
        Ending = false;
    }
}
