using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : Singleton<PauseManager>
{
    public GameObject PausaMenu;
    public bool PauseSatate;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            ChangeStatePause();

        if (PauseSatate)
        {
            PausaMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PausaMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void ChangeStatePause()
    {
        PauseSatate = !PauseSatate;
    }
}
