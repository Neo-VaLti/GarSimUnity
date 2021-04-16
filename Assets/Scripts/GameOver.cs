using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverText;
    public static GameObject gameOverStatic;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.gameOverStatic = gameOverText;
        GameOver.gameOverStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void mostrar()
    {
        GameOver.gameOverStatic.gameObject.SetActive(true);
    }
}
