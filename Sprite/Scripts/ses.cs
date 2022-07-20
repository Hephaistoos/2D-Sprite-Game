using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ses : MonoBehaviour
{
    public AudioSource music;
    float volume = 0f;

    void Start()
    {
        music.Play();
    }

    private void Update()
    {
        music.volume = volume;
    }

    public void volumechange(float value)
    {

        volume = value;
        DontDestroyOnLoad(music);
    }
}
   