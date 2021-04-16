using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    
    public int tiempoInicial;
    [Range(-10.0f, 10.0f)]
    public float escalaTiempo = 0;

    private Text txtTiempo;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAmostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado = false;

    //variables cambio escena
    public float tiempoStart = 0.0f;
    public float tiempoEnd = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        escalaDeTiempoInicial = escalaTiempo;

        txtTiempo = GetComponent<Text>();

        tiempoAmostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);

    }

    // Update is called once per frame
    void Update()
    {
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaTiempo;
        tiempoAmostrarEnSegundos -= tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAmostrarEnSegundos);
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        //Asegura que el tiempo no sea negativo
        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        //Calcula los minutos y segundos
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        //Crea la cadena de caracteres con 2 digitos para los minutos y segundos, separados por ":"
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        //Actualiza el elemento UI de text con la cadena de caracteres.
        txtTiempo.text = textoDelReloj;


        if (textoDelReloj.Equals("00:00"))
        {
            GameOver.mostrar();
        }
        tiempoStart += Time.deltaTime;
        if (tiempoStart >= tiempoEnd)
        {
            SceneManager.LoadScene("ciudad");
        }

    }
}
