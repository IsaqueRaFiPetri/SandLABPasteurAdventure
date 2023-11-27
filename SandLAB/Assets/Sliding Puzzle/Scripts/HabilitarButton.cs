using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class HabilitarButton : MonoBehaviour
{
    float cronometro;


    private void Start()
    {
        cronometro = 0;
    }

    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro >= 0.2f) //5Hz
        {
            cronometro = 0;
                        
        }
    }
}
