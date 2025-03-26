using TMPro;
using TreeEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseCurser : MonoBehaviour
{
    [SerializeField] private Camera m_Camera;

    public bool mouseDown;
    public bool mouseOverTrigger;

    private static MouseCurser mouseInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (mouseInstance == null)
        {
            mouseInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }


    private void Update()
    {

        SetMousePosition();

        DetectClick();

    }

    private void SetMousePosition()
    {
        Vector3 mouseWorldPosition = m_Camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        transform.position = mouseWorldPosition;
    }

    private void DetectClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mouseDown = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            mouseDown = false;
        }
    }

}
