using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private GameObject painelControles;
    public string sceneNameToLoad;

    public void Creditos()
    {
        painelCreditos.SetActive(true);
        Debug.Log("Créditos");
    }
    public void Controles()
    {
        painelControles.SetActive(true);
        Debug.Log("controls");
    }
    public void SairDosCreditos()
    {
        painelCreditos.SetActive(false);
        Debug.Log("Sair painel");
    }
    public void SairDosControles()
    {
        painelControles.SetActive(false);
        Debug.Log("Sair painel");
    }
    public void PlayBTN()
    {
        SceneManager.LoadScene(sceneNameToLoad);
        Debug.Log("Play");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
