using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerguntasBTNControls : MonoBehaviour
{
    public GameObject proximaPergunta; // The name of the scene you want to load
    public GameObject pergunta1; // The name of the scene you want to load
    public GameObject perguntaAtual;
    public GameObject painelDasPerguntas;
    [SerializeField] private Button CorrectButton;

    void Awake()
    {
        CorrectButton.onClick.AddListener(OnCorrectButtonClick);
    }

    void OnCorrectButtonClick()
    {
        Debug.Log("Acertou");
    }
    public void BTNCerto()
    {
        proximaPergunta.SetActive(true);
        perguntaAtual.SetActive(false);
    }

    public void BTNErrado()
    {
        pergunta1.SetActive(true);
        perguntaAtual.SetActive(false);
    }
    public void BTNLastQuestionCorect()
    {
        painelDasPerguntas.SetActive(false);
        proximaPergunta.SetActive(true);
    }

}
