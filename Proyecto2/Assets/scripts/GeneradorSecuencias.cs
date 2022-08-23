using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorSecuencias : MonoBehaviour
{

    private int maxNumbers = 100;
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
}

public enum Steps
{
    left = 1,
    right = 2,
    up = 3,
    down = 4,
}