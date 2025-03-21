using System.Runtime.CompilerServices;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class SteamPunkMachine : MonoBehaviour
{
    [SerializeField] private Animator _Animator;
    [SerializeField] private MouseCurser _MouseCurser;
    [SerializeField] private PlayerStats _PlayerStats;

    [SerializeField] private GameObject _PermanentUpgradeUI;

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
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
            _Animator = GetComponent<Animator>();
            _MouseCurser = FindAnyObjectByType<MouseCurser>();
        }
    }

    private void Update()
    {
       
       ActivateMachine();
       CloseUpgradeUI();

    }

    private void ActivateMachine()
    {

        if (_MouseCurser.mouseOverTrigger && _MouseCurser.mouseDown)
        {
            open = true;
        }

        if (open == true)
        {
            _Animator.Play("Machine_Open");
        }
        else if (open == false)
        {
            _Animator.Play("Machine_Idle");
        }

        if (_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f && !_Animator.IsInTransition(0) && open == true)
        {
            _PermanentUpgradeUI.SetActive(true);
            open = false;
        }

    }

    private void CloseUpgradeUI()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _PermanentUpgradeUI.SetActive(false);
        }
    }
}
