using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    [SerializeField] public JugadosSO  P1;
    public int vida;
    public int proyectil1;
    public int proyectil2;
    public bool llave1;
    public bool llave2;



    void Awake() {
        vida = P1.vida;
        proyectil1 = P1.proyectil1;
        proyectil2 = P1.proyectil2;
        llave1 = P1.llave1;
        llave2 = P1.llave2;
    }

    // Start is called before the first frame update
    void Start() { 
        vida = P1.vida;
        proyectil1 = P1.proyectil1;
        proyectil2 = P1.proyectil2;
        llave1 = P1.llave1;
        llave2 = P1.llave2;

    }

    // Update is called once per frame
    void Update() {

     }

    public void agregarVida(int Vida)
    {
        vida = vida + Vida;
        P1.vida = vida;
    }

    public void agregarProyectil1(int Proyectil)
    {
        proyectil1 = proyectil1 + Proyectil;
        P1.proyectil1 = proyectil1;
    }

    public void agregarProyectil2(int Proyectil)
    {
        proyectil2 = proyectil2 + Proyectil;
        P1.proyectil2 = proyectil2;

    }

    public void agregarLlave1(bool llave)
    {
        llave1 = llave;
        P1.llave1 = llave1;
    }

    public void agregarLlave2(bool llave)
    {
        llave2 = llave;
        P1.llave2 = llave2;
    }
}
