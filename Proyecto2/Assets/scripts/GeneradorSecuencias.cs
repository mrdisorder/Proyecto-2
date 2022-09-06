using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorSecuencias : MonoBehaviour
{
    public GameObject[] flechaASpawnear;
    int flechaID;
    [SerializeField]  public float spawnDelay = 0f;


    [SerializeField] int maxNumbers = 10;
    private List<Steps> secuenciaGenerada;

    void Start()
    {
        secuenciaGenerada = new List<Steps>();
        GenerarSecuencia();
    }

    public void GenerarSecuencia()
    {

        for (int i = 0; i < maxNumbers; i++)
        {
            Steps paso = (Steps)Random.Range(1, 5);
            secuenciaGenerada.Add(paso);
        }

        //Just to see them in the console
        foreach (Steps data in secuenciaGenerada)
        {
            Debug.Log(data.ToString());
        }
    }

    private IEnumerator SpawnArrow()
    {
        for (int i=0;i<maxNumbers;i++)
        {
            var g = Instantiate(GetArrowPrefab());
            yield return new WaitForSeconds(1);
            Destroy(g);
            yield return new WaitForSeconds(0.5f);

        }
    }

    private GameObject GetArrowPrefab(Steps steps)
    {
        switch (steps)
        {
            case (Steps)1:
                return new GameObject("flecha izquierda");
            case (Steps)2:
                return new GameObject("flecha derecha");
            case (Steps)3:
                return new GameObject("flecha arriba");
            case (Steps)4:
                return new GameObject("flecha abajo");
        }
    }
}


public enum Steps
{
    left = 1,
    right = 2,
    up = 3,
    down = 4,
}