using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour 
{
    public int seconds;
    
    public void StartGame()
    {
        StartCoroutine(Loading(seconds));
    }

    IEnumerator Loading(int seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);

           
        }
    }
}
