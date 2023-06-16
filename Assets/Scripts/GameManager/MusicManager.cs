using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : Singleton<MusicManager>
{
    public PauseManager pausemanager;
    public AudioSource music;
    public bool MusicOn;
    // Start is called before the first frame update
    void Start()
    {
        pausemanager = FindAnyObjectByType<PauseManager>();
        music = this.GetComponent<AudioSource>();
        MusicOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeStateMusic();
    }
    
    void ChangeStateMusic()
    {
        if (pausemanager.PauseSatate)
        {
            MusicOn = false;
            music.Pause();
        }
        else
        {
            MusicOn = true;
            music.UnPause();
        }
    }

}
