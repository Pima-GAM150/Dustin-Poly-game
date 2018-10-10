using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Filler : MonoBehaviour
{
    public Image LoadingBar;
    public float Seconds;

    private int nscene;
    private bool ending;

    private void Start()
    {
        LoadingBar.fillAmount = 0.0f;
        nscene = 0;
        ending = false;

        StartCoroutine(Loading(Seconds));
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

        if (ending)
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(nscene);
            nscene++;
            if (nscene >= 2)
            {
                ending = true;
            }
        }
    }
}
