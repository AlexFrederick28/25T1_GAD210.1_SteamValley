using TMPro;
using TreeEditor;
using UnityEngine;

public class MouseCurser : MonoBehaviour
{
    [SerializeField] private Camera m_Camera;

    public bool mouseDown;
    public bool mouseOverTrigger;

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
