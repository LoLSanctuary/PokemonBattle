using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intn : MonoBehaviour {

    int numero ;
  
    
    // Use this for initialization
    void Start()
    {
      
        imprimir(3);
        imprimir(24);

    }

    void imprimir(int numero)
    {

        if (numero % 2 > 0)
        {
            Debug.Log("Estranho");
        }
        else if (numero >= 2 && numero <= 5)
        {
            Debug.Log("Não estranho");
        }
        else if (numero >= 6 && numero <= 20)
        {
            Debug.Log("Estranho");
        }
        else
        {
            Debug.Log("Não estranho");
        }
    }
}
