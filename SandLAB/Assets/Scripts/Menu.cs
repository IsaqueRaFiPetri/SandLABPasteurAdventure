using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private Button playBTN;
    [SerializeField] private Button quitlBTN;
    [SerializeField] private Button sairCreditosBTN;
    [SerializeField] private Button CretisBTN;
    public string sceneNameToLoad;

    public void Creditos()
    {
        painelCreditos.SetActive(true);
        Debug.Log("Créditos");
    }
    public void SairDosCreditos()
    {
        painelCreditos.SetActive(false);
        Debug.Log("Sair Créditos");
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
