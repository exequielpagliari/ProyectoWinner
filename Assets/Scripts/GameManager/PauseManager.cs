using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : Singleton<PauseManager>
{
    public GameObject PausaMenu;

    private GameObject pausamenu;

    public bool PauseSatate;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (pausamenu == null)
        {
            Instantiate(PausaMenu);
            pausamenu = GameObject.FindGameObjectWithTag("pausemenu");
            pausamenu.transform.SetParent(
                GameObject.FindGameObjectWithTag("canvas").transform,
                false
            );
        }
        if (Input.GetButtonDown("Cancel"))
            ChangeStatePause();

        if (PauseSatate)
        {
            pausamenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausamenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void ChangeStatePause()
    {
        PauseSatate = !PauseSatate;
    }
}
