using Unity.VisualScripting;
using UnityEngine;

public class SingletonCamera : MonoBehaviour
{
    private static SingletonCamera cameraInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (cameraInstance == null)
        {
            cameraInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    private void Update()
    {
        DontDestroyOnLoad (cameraInstance);
    }
}
