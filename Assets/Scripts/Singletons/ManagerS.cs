
using UnityEngine;

public class ManagerS : MonoBehaviour
{
    public static ManagerS Manager { get; private set; }

    private GameObject mgr;
    private void Awake()
    {
        if(Manager == null)
        {
            mgr = GameObject.Find("Manager");

            Manager = mgr.GetComponent<ManagerS>();

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
