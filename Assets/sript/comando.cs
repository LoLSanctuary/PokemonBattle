using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comando : MonoBehaviour {

     int nivel = 5;
     int poder = 9;
     int atk = 14;
     int modificador = 1;
     public bool critico;
     int tipoAtaque;


	// Use this for initialization
	void Start () {
        int dano;

        dano = ((((2 * nivel / 5) + 2 * poder * atk) / 50) + 2) * modificador;
        if (critico)
        {
            dano = dano * 2;
        }
         Debug.Log(dano);
	}
}
