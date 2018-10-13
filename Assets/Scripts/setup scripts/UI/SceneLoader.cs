using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{/*
    public float Seconds;
    public CanvasGroup PanelToFade;
    [HideInInspector] public bool MainMenu;
    [HideInInspector] public bool Level1, Level2, Level3;

    int BuildIndex;
    float StartedLerping;
    float SinceStart;
    float PercentageComplete;
    float CurrentValue;
    Scene LoadedScene;

    private void Start()
    {
        FadeIn();
    }

    public void FadeIn()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 0, Seconds));
    }
    public void FadeOut()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 1, Seconds));

        LoadNextScene();
    }
    

    IEnumerator Fade(CanvasGroup cg, float Start, float End, float LerpTime)
    {
        StartedLerping = Time.time;
        SinceStart = Time.time - StartedLerping;
        PercentageComplete = SinceStart / LerpTime;

        while (true)
        {
            SinceStart = Time.time - StartedLerping;
            PercentageComplete = SinceStart / LerpTime;
            CurrentValue = Mathf.Lerp(Start, End, PercentageComplete);

            PanelToFade.alpha = CurrentValue;

            yield return new WaitForEndOfFrame();
        }
    }
    IEnumerator WaitForFade (float seconds, int LevelToLoad)
    {
        yield return new WaitForSeconds(seconds);

        LoadNextScene();

        FadeIn();

    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(BuildIndex);
        FadeIn();
    }

    private void OnLevelWasLoaded(int level)
    {
        LoadedScene = SceneManager.GetActiveScene();

        if (LoadedScene.buildIndex != 4)
        {
            BuildIndex = 4;
        }
        else if (LoadedScene.buildIndex != 3 && MainMenu)
        {
            BuildIndex = 3;
        }
        else if (LoadedScene.buildIndex < 3)
        {
            if (Level1)
            {
                BuildIndex = 1;
                if(Level2)
                {
                    BuildIndex = 2;
                    if(Level3)
                    {
                        BuildIndex = 5;
                    }
                }
            }
            else
            {
                BuildIndex = 0;
            }
        }
    }
    /*   public void LoadNextScene()
    {
        FadeOut();
    }
    void Load()
      {
          LoadedScene = SceneManager.GetActiveScene();

          if (string.Compare(LoadedScene.name, "Loading Scene") != 0 && Loading)
          {
              SceneManager.LoadSceneAsync(4);
              FadeIn();
              Loading = false;
          }
          else if(string.Compare(LoadedScene.name, "Main Menu Scene") != 0 && MainMenu)
          {
              SceneManager.LoadSceneAsync(3);
              FadeIn();
              MainMenu = false;
          }
          else if(string.Compare(LoadedScene.name, "Ending") != 0 && Ending)
          {
              SceneManager.LoadSceneAsync(5);
              FadeIn();
              Ending = false;
          }
          else
          {
              if(BuildIndex<3)
              {
                  SceneManager.LoadSceneAsync(BuildIndex);
                  Loading = true;
                  BuildIndex++;
                  FadeIn();
              }
              else if(BuildIndex == 3)
              {
                  Ending = true;
              }
              else
              {
                  BuildIndex = 0;
              }

          }
      }
  /*  void Load()
    {
       // LoadedScene = SceneManager.GetActiveScene();

        if (MainMenu)
        {
            SceneManager.LoadScene(3);
            FadeIn();
            Loading = true;
        }
        else if (Loading)
        {
            SceneManager.LoadScene(4);
            FadeIn();
            Loading = false;
        }
        else if (Ending)
        {
            SceneManager.LoadScene(5);
            FadeIn();
        }
        else
        {
            if(BuildIndex < 3)
            {
                SceneManager.LoadScene(BuildIndex);
                FadeIn();
                Loading = true;
                BuildIndex++;
            }
            else if(BuildIndex == 3)
            {
                Ending = true;
                BuildIndex = 0;
            }
            else
            {

            }
        }

    }

   /* void Load()
    {
        LoadedScene = SceneManager.GetActiveScene();


    }*/

}
