using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaTutorial : MonoBehaviour
{


    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.tag == "RegresarMenu")
        {
            SceneManager.LoadScene("menu");
        }
    }

}
