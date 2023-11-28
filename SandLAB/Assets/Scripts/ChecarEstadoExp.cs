using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarEstadoExp : MonoBehaviour
{
    public bool complete;
    float cronometro;

    MoveObj2DExp[] objetos;

    void Start()
    {
        cronometro = 0;
        complete = false;
        objetos = FindObjectsOfType<MoveObj2DExp>();
    }
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro >= 0.2f) //5Hz
        {
            cronometro = 0;
            int soma = 0;
            for (int x = 0; x < objetos.Length; x++)
            {
                if (objetos[x].isConected)
                {
                    soma++;
                }
            }
            if (soma >= objetos.Length)
            {
                complete = true;

            }
        }
    }
}
