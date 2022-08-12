using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectsCollection;
    GameObject player;
    int random;
    [SerializeField] Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
        player = GameObject.FindGameObjectWithTag("Player");
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PosicionarElementosDelArray();
            GenerarNumeroAlAzar();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstanciarObjetoAlAzarDelArray();
        }
    }
    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            Destroy(objectsCollection[i]);
        }
    }
    void PosicionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(-3.569288f + i, 0.481f, 0.69f);
        }
    }
    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }
    void GenerarNumeroAlAzar()
    {
        random = Random.Range(1,11);
    }
    void InstanciarObjetoAlAzarDelArray()
    {
        Instantiate(objectsCollection[Random.Range(0,objectsCollection.Length)], SpawnPoint.position, Quaternion.identity);
    }
}
