using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
    [SerializeField] private JugadosSO P1;
    public TMP_Text nombre;
    public TMP_Text vida;
    public TMP_Text proyectil1;
    public TMP_Text proyectil2;
    public TMP_Text llave1;
    public TMP_Text llave2;
    public  Image image;
    
    // Start is called before the first frame update

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nombre.text = P1.nombre;
        vida.text = "Cant de Vidas " + P1.vida.ToString();
        proyectil1.text = "Cant de Proyectil 1 " + P1.proyectil1.ToString();
        proyectil2.text = "Cant de Proyectil 2 " + P1.proyectil2.ToString();
        llave1.text = "Tengo llave1 " + P1.llave1.ToString();
        llave2.text = "Tengo llave2 " + P1.llave2.ToString();
        //P1.caraImagen = image.sprite;

    }
}
