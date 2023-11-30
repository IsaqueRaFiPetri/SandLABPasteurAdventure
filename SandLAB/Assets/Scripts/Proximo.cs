using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proximo : MonoBehaviour
{
    public GameObject textoAtual;
    public GameObject textoProximo;

    [Space(10)]
    public GameObject gameOverPainel;
    public GameObject winPainel;

    [Space(10)]
    public string menuScene;
    public string gameScene;

    public void ProximoTexto()
    {
        textoAtual.SetActive(false);
        textoProximo.SetActive(true);
    }

    public void ErrouAsPerguntas()
    {
        textoAtual.SetActive(false);
        gameOverPainel.SetActive(true);
    }

    public void AcertouAsPerguntas()
    {
        textoAtual.SetActive(false);
        winPainel.SetActive(true);
    }

    public void MenuBTN()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void RefazerFase()
    {
        SceneManager.LoadScene(gameScene);
    }
}
