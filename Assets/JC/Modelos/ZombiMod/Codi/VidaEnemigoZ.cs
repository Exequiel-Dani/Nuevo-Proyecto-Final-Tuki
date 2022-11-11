using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* vida enemigo*/ 
public class VidaEnemigoZ : MonoBehaviour
{
    /* Variables */
    private int vidaEnemigo=100;
    public Animator animator;

    public int cantidad;

    public Slider barraVitalidad;
    
    void Update(){
        barraVitalidad.GetComponent<Slider>().value = vidaEnemigo; //actualiza la barra de vitalidad según el valor de vitalidad
    }

    /*  Función de recibir daño */
    public void RestarVidaEnemigo(int cantidad)
    {
        vidaEnemigo -= cantidad; //resta la cantidad de daño a la vitalidad
        
        if(vidaEnemigo<=0) //si el enemigo pierde toda la vitalidad
        {
            AudioManager.instance.Play("Muerte"); //Ejecuta Audio
            animator.SetTrigger("muerto"); //animación de muerte
            GetComponent<Collider>().enabled=false; //desactivación de colisionador
        }
        else
        {
            AudioManager.instance.Play("Herido");
            animator.SetTrigger("herido"); //animación de herida
            

        }
    }
 
}
