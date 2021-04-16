using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAutos : MonoBehaviour
{
    public GameObject[] objetos;
    public float tiempoMinSpawn;
    public float tiempoMaxSpawn;
    public bool spawnObjMov = false;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnObjMov)
        {
            SpawnMovingObjects();
        }
        else
        {
            SpawnStaticObjects();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * Time.deltaTime);
    }

    void SpawnMovingObjects()
    {
        Instantiate(objetos[Random.Range(0, objetos.Length)], transform);
        Invoke("SpawnMovingObjects", Random.Range(tiempoMaxSpawn, tiempoMaxSpawn));
    }

    void SpawnStaticObjects()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(objetos[Random.Range(0, objetos.Length)], 
                new Vector3(Random.Range(-5, 5), 0, transform.position.z), Quaternion.identity);
        }
    }
}
