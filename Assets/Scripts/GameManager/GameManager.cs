using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    public AudioClip cancion1;
    public AudioClip cancion2;
    public AudioClip cancion3;
    public AudioClip cancion4;

    public AudioSource MusicManager;

    void Start()
    {
        // TODO:
        // - Load player save
        // - If no save, redirect player to registration scene
        // - Call backend and get daily challenge and rewards
        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: " + DateTime.Now);
    }

    void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);
        Debug.Log("Game session ended @: " + DateTime.Now);
        Debug.Log("Game session lasted: " + timeDifference);
    }

    void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (GUILayout.Button("Prev Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (GUILayout.Button("Parar Música"))
        {
            MusicManager.Stop();
        }

        if (GUILayout.Button("Canción 1"))
        {
            MusicManager.clip = cancion1;
            MusicManager.Play();
        }

        if (GUILayout.Button("Canción 2"))
        {
            MusicManager.clip = cancion2;
            MusicManager.Play();
        }

        if (GUILayout.Button("Canción 3"))
        {
            MusicManager.clip = cancion3;
            MusicManager.Play();
        }

        if (GUILayout.Button("Canción 4"))
        {
            MusicManager.clip = cancion4;
            MusicManager.Play();
        }

        if (GUILayout.Button("Salir"))
        {
            Application.Quit();
            OnApplicationQuit();
        }
    }
}
