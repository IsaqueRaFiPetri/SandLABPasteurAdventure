using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePainel : MonoBehaviour
{
    public GameObject painel;

    public void OpenPainel()
    {
        painel.SetActive(true);
    }

    public void ClosePainel() 
    {
        painel.SetActive(false);
    }
}
