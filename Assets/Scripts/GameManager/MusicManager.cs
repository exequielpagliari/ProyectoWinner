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
        if(pausemanager.PauseSatate){
            music.Pause();
        }

        if(!pausemanager.PauseSatate)
        music.UnPause();
    }
    
    void ChangeStateSound()
    {
        if (pausemanager.PauseSatate)
        {
            MusicOn = false;
        }
        else
        {
            MusicOn = true;
        }
    }

}
