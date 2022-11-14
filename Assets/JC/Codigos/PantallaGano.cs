using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaGano : MonoBehaviour

{
    [SerializeField] static bool JuegoPausado=true;
    [SerializeField] private GameObject menuFin;

    // Start is called before the first frame update
    void Start()
    {
       Cursor.visible=true;
       Cursor.lockState=CursorLockMode.None;

    }
      
    public void CargarMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(0);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
}
