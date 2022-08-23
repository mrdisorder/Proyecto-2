using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaIngresada : MonoBehaviour
{
    public List<Steps> secuenciaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        secuenciaIngresada = new List<Steps>();
        IngresarSecuencia();
    }

    public void IngresarSecuencia()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Steps data in secuenciaIngresada)
        {
            Debug.Log(data.ToString());
        }
    }
}
