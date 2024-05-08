using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject sessions;

    public void OnPlay()
    {
        mainMenu.SetActive(false);
        sessions.SetActive(true);
    }

    public void SoloSession()
    {
        SceneManager.LoadScene(1);
    }

    public void GuidedSession()
    {
        SceneManager.LoadScene(2);
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
