using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiosDeEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarTutorial(string cargarTutorial)
    {
        SceneManager.LoadScene(cargarTutorial);
        Debug.Log("Has entrado al tutorial");
    }

    public void iniciarJuego(string cargarJuego)
    {
        SceneManager.LoadScene(cargarJuego);
        Debug.Log("Has entrado al juego satisfactoriamente");
    }

    public void salirAlEscritorio()
    {
        Application.Quit();
        Debug.Log("Saliste completamente del juego");
    }

    public void salirAlMenu(string cargarMenu)
    {
        SceneManager.LoadScene(cargarMenu);
        Debug.Log("Regresaste al menu");
    }
}
