using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectManager : MonoBehaviour
{
    
    [SerializeField] private GameObject mouseCurser;
    [SerializeField] private GameObject steamPunkMachine;
    [SerializeField] private GameObject upgradeUI;
    [SerializeField] private GameObject challengeButton;
    [SerializeField] private GameObject playerStatUI;


    private static ObjectManager managerInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (managerInstance == null)
        {
            managerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    private void Update()
    {
        DontDestroyOnLoad (this);
        EnteringChallengeScene();
    }

    private void EnteringChallengeScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene == SceneManager.GetSceneByBuildIndex(1))
        {
            //mouseCurser.SetActive(false);
            steamPunkMachine.SetActive(false);
            upgradeUI.SetActive(false);
            challengeButton.SetActive(false);
        }
        else
        {
            mouseCurser.SetActive(true);
            steamPunkMachine.SetActive(true);
            upgradeUI.SetActive(true);
            challengeButton.SetActive(true);
        }

        playerStatUI.SetActive(true);
    }
}
