using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositarObjetos : MonoBehaviour
{

    public GameObject score;
    public static int contador;
    public AudioClip audioDeposito;

    private void OnCollisionEnter(Collision collision)
    {

        switch(collision.gameObject.tag){
            case "DepositarOrganico":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
            case "DepositarElectronico":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
            case "DepositarVidrio":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
            case "DepositarPlastico":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
            case "DepositarMetal":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
            case "DepositarPapel":
                gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 0.7f);
                Destroy(collision.gameObject);
                contador += 15;
                score.GetComponent<Text>().text = contador.ToString();
                break;
        }
        //GameObject organicos = GameObject.FindWithTag("ObjOrganico");
        //if (collision.gameObject.tag == "DepositarOrganico")
        //{
        //    gameObject.GetComponent<AudioSource>().PlayOneShot(audioDeposito, 15f);
        //    Destroy(collision.gameObject);
        //    contador += 15;
        //    score.GetComponent<Text>().text = contador.ToString();

        //}
    }


}
