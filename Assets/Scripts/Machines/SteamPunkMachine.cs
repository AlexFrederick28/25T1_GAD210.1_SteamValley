using UnityEditor.Animations;
using UnityEngine;

public class SteamPunkMachine : MonoBehaviour
{
    [SerializeField] private Animator _Animator;
    [SerializeField] private MouseCurser _MouseCurser;

    [SerializeField] private bool open;
    [SerializeField] private bool idle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MouseCurser>())
        {
            _MouseCurser.mouseOverTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<MouseCurser>())
        {
            _MouseCurser.mouseOverTrigger = false;
        }
    }

    private void Start()
    {
        if (_MouseCurser == null)
        {
            _Animator = GetComponent<Animator>();
            _MouseCurser = FindAnyObjectByType<MouseCurser>();
        }
    }

    private void Update()
    {
        if (_MouseCurser.mouseOverTrigger && _MouseCurser.mouseDown)
        {
            open = true;
        }
       
        if (open == true)
        {
            _Animator.Play("Machine_Open");

            open = false;
        }
        else if (open == false)
        {
            _Animator.Play("Machine_Idle");
        }
    }
}
