
using UnityEngine;

public class ManagerS : MonoBehaviour
{
    public static ManagerS Manager = null;

    private void Awake()
    {
        if (Manager == null)
        {
            Manager = this;
        }
        else if(Manager != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

}
