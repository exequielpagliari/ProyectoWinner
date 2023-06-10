using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPruebasBotones : MonoBehaviour
{
    
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }


    


        public void Sonido1()
        {
            
            AudioSource.PlayClipAtPoint(clip1, transform.position);
        }

        public void Sonido2()
        {
            AudioSource.PlayClipAtPoint(clip2, transform.position);
        }

        public void Sonido3()
        {
            AudioSource.PlayClipAtPoint(clip3, transform.position);
        }

        public void Sonido4()
        {
            AudioSource.PlayClipAtPoint(clip4, transform.position);
        }

        public void Sonido5()
        {
            AudioSource.PlayClipAtPoint(clip5, transform.position);
        }

        public void Sonido6()
        {
            AudioSource.PlayClipAtPoint(clip6, transform.position);
        }
}
