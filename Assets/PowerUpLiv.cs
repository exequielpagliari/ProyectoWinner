using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpLiv : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<inventario>().agregarVida(1);
            Destroy(this.gameObject);
        }
    }
}
