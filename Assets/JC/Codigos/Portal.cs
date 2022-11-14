using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* paso de nivel por portal */
public class Portal : MonoBehaviour



{

    [SerializeField] int escena;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            //AudioManager.instance.Play("Nivel"); //Ejecuta Audio
            SceneManager.LoadScene(escena);
        }
    }
}
