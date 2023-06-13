using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    private float _poscX;
    private float _poscY;
    public float velocityX;
    public float velocityY;

    private AudioClip audioSuena;

    public AudioClip chocar;

    public AudioClip caminar;

    public Rigidbody2D rb;

    public AudioSource audioSource;

    public SoundManager soundmanager;

    private void Start()
    {
        soundmanager = FindAnyObjectByType<SoundManager>();
    }

    void Wake()
    {
        _poscX = this.transform.position.x;
        _poscY = this.transform.position.y;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);

        if (rb.velocity.x != 0)
        {
            sonido("caminar");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            velocityX = velocityX * -1;
            sonido("chocar");
        }
    }

    void sonido(string sonido)
    {
        if (sonido == "chocar")
        {
            audioSuena = chocar;
        }

        if (sonido == "caminar")
        {
            if (!audioSource.isPlaying)
                audioSuena = caminar;
        }

        audioSource.clip = audioSuena;
        if (!soundmanager.SoundOn)
            audioSource.Pause();
            else{
        if (soundmanager.SoundOn)
            audioSource.UnPause();
        if (!audioSource.isPlaying)
            audioSource.Play();
            }
    }
}
