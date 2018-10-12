using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public float Seconds;
    public CanvasGroup PanelToFade;
    public bool Loading;
    public bool MainMenu;
    public bool Ending;

    int BuildIndex;
    float StartedLerping;
    float SinceStart;
    float PercentageComplete;
    float CurrentValue;
    Scene LoadedScene;

    private void Start()
    {
        FadeIn();
        BuildIndex = 4;
    }

    public void FadeIn()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 0, Seconds));

        StopCoroutine("Fade");
    }
    public void FadeOut()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 1, Seconds));
        StartCoroutine(WaitForFade(Seconds,BuildIndex));
        StopCoroutine("Fade");
    }
    public void LoadNextScene()
    {
        FadeOut();
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

        SceneManager.LoadScene(LevelToLoad);

        FadeIn();

    }

    /*  void Load()
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
