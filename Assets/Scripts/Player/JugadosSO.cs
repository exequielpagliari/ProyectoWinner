using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "ScriptableObject/Personaje")]
public class JugadosSO : ScriptableObject
{

    public string nombre;
    public Sprite caraImagen;
    public int vida;
    public int proyectil1;
    public int proyectil2;
    public bool llave1;
    public bool llave2;




}
