using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarEstado : MonoBehaviour
{
    public bool complete;
    float cronometro;

    MoverObject2D[] objetos;

    void Start()
    {
        cronometro = 0;
        complete = false;
        objetos = FindObjectsOfType<MoverObject2D>();
    }
}
//video de referencia: https://www.youtube.com/watch?v=EohhGbRgNds
