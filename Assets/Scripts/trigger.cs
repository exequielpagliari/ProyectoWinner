using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject cosa;
    public Camera camara;
    // Start is called before the first frame update
    
    private bool cae;
    void Start()
    {
        cae = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cae == true)
        camara.transform.position = new Vector3(cosa.transform.position.x,cosa.transform.position.y, -10f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        cae = true;
    }
}
