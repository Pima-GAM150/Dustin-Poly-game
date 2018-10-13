using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Filler : MonoBehaviour
{
    public Image LoadingBar;
    public float Seconds;
    public SceneLoader PanalToFade;

    private void Start()
    {
        //PanalToFade.FadeIn();
        LoadingBar.fillAmount = 0.0f;
        
        StartCoroutine(Loading(Seconds));

        StopCoroutine("Loading");

       // PanalToFade.FadeOut();
    }

    IEnumerator Loading(float seconds)
    {
        float i = 0;
        while (i <= seconds*10)
        {
            yield return new WaitForSeconds(seconds);

            LoadingBar.fillAmount += seconds / 10.0f;

            i++;
        }
    }
}
