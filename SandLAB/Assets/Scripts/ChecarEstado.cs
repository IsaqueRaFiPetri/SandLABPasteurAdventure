using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChecarEstado : MonoBehaviour
{
    public bool complete;
    float cronometro;
    public string sceneName;

    MoverObject2D[] objetos;

    void Start()
    {
        cronometro = 0;
        complete = false;
        objetos = FindObjectsOfType<MoverObject2D>();
    }
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro >= 0.2f) //5Hz
        {
            cronometro = 0;
            int soma = 0;
            for(int x = 0; x < objetos.Length; x++)
            {
                if (objetos[x].isConected)
                {
                    soma++;
                }
            }
            if(soma >= objetos.Length)
            {
                complete = true;
                SceneManager.LoadScene(sceneName);

            }
        }
    }
}
//video de referencia: https://www.youtube.com/watch?v=EohhGbRgNds
