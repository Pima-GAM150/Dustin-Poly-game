using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public float Seconds;
    public CanvasGroup PanelToFade;

    public string[] SceneNames;

    private static int scene;
    float StartedLerping;
    float SinceStart;
    float PercentageComplete;
    float CurrentValue;

    private void Start()
    {
        FadeIn();
        scene = 1;
    }

    public void FadeIn()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 0, Seconds));

        StopCoroutine("Fade");
    }
    public void FadeOut()
    {
        StartCoroutine(Fade(PanelToFade, PanelToFade.alpha, 1, Seconds));

        StopCoroutine("Fade");
    }
    public void LoadNextScene( int SceneIndex)
    {
        FadeIn();

        Load(SceneIndex);
    }

    IEnumerator Fade(CanvasGroup cg, float Start, float End, float LerpTime )
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

    void Load( int SceneIndex)
    {
        SceneManager.LoadScene(SceneNames[SceneIndex]);
    }
}
