using System.Collections;
using UnityEngine;

public class Corutine : MonoBehaviour
{
    public int Seconds
    {
        get
        {
            return seconds;
        }

        set
        {
            seconds = value;
        }
    }

    private int seconds;

    private void Start()
    { 

        StartCoroutine(Loading(seconds));
    }

    IEnumerator Loading(int seconds)
    {
        while(true)
        {
            yield return new WaitForSeconds(seconds);
        }
    }

}
