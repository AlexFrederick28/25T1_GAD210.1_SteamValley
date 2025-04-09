using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject mouseCurser;
    [SerializeField] private GameObject steamPunkMachine;
    [SerializeField] private GameObject upgradeUI;
    [SerializeField] private GameObject challengeButton;
    [SerializeField] private GameObject playerStatUI;
    [SerializeField] private GameObject[] chooseClass;


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
            steamPunkMachine.SetActive(true);
            challengeButton.SetActive(true);
            player.SetActive(false);
        }
        else
        {
            //mouseCurser.SetActive(true);
            steamPunkMachine.SetActive(false);
            upgradeUI.SetActive(false);
            challengeButton.SetActive(false);
        }

        if (currentScene == SceneManager.GetSceneByBuildIndex(2))
        {
            player.SetActive(true);
        }

        if (currentScene == SceneManager.GetSceneByBuildIndex(0))
        {
            playerStatUI.SetActive(false);
            foreach (var item in chooseClass)
            {
                item.gameObject.SetActive(true);
            }
        }
        else
        {
            playerStatUI.SetActive(true);
            foreach (var item in chooseClass)
            {
                item.gameObject.SetActive(false);
            }
        }

    }
}
