﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour, IFadeComplete {

    public int seconds;
    
    IEnumerator Loading(int seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            
        }
    }

    public void StartGame ()
    {
        StartCoroutine(Loading(seconds));
        
    }
    void IFadeComplete.OnFadeComplete()
    {
        SceneManager.LoadScene("Loading Scene");
    }
    
}
