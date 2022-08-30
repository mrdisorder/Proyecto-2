using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaIngresada : MonoBehaviour
{
    [SerializeField] int maxNumbers = 100;
    private List<Steps> secuenciaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        secuenciaIngresada = new List<Steps>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            secuenciaIngresada.Add(Steps.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            secuenciaIngresada.Add(Steps.right);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            secuenciaIngresada.Add(Steps.left);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            secuenciaIngresada.Add(Steps.left);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (Steps data in secuenciaIngresada)
            {
                Debug.Log(data.ToString());
            }
        }

        
    }

    /*
    public void IngresarSecuencia()
    {
    

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                
                secuenciaIngresada.Add(Steps.left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Steps paso = (Steps)2;
                secuenciaIngresada.Add(paso);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Steps paso = (Steps)3;
                secuenciaIngresada.Add(paso);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Steps paso = (Steps)4;
                secuenciaIngresada.Add(paso);
            }

        

        foreach (Steps data in secuenciaIngresada)
        {
            Debug.Log(data.ToString());
        }
    }
     */


}