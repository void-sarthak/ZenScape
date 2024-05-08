using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoloMenu : MonoBehaviour
{
    public AudioSource medAudio;

    public void OnStart()
    {
        medAudio.Play();
    }

    public void OnPause()
    {
       medAudio.Pause();
    }

    public void OnExit()
    {
        SceneManager.LoadScene(0);
    }
}
