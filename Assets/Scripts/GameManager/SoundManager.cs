using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public bool SoundOn;

    public float SoundVolume;

    private PauseManager pausemanager;

    // Start is called before the first frame update
    void Start()
    {
        SoundOn = true;
        pausemanager = FindAnyObjectByType<PauseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeStateSound();
    }

    void ChangeStateSound()
    {
        if (pausemanager.PauseSatate)
        {
            SoundOn = false;
        }
        else
        {
            SoundOn = true;
        }
    }
}
