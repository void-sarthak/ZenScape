using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroupStart : MonoBehaviour
{
    public Animator[] anim;
    public AudioSource medAudio;

    public void OnStart()
    {
        for(int i = 0;  i < anim.Length; i++)
        {
            anim[i].SetBool("isSit", true);
        }

        medAudio.Play();

    }

    public void OnPause()
    {
        for (int i = 0; i < anim.Length; i++)
        {
            anim[i].SetBool("isSit", false);
        }

        medAudio.Pause();

    }

    public void OnExit()
    {
        SceneManager.LoadScene(0);
    }
}
