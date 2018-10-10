
using UnityEngine;

public class ManagerS : MonoBehaviour
{
    public static ManagerS Manager { get; private set; }


    private void Awake()
    {
        if(Manager == null)
        {
            Manager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
