using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompleteAsLacunasButtonControls : MonoBehaviour
{
    public string proximaPergunta; // The name of the scene you want to load
    public string pergunta1; // The name of the scene you want to load
    [SerializeField] private Button CorrectButton;

    void Awake()
    {
        CorrectButton.onClick.AddListener(OnCorrectButtonClick);
    }

    void OnCorrectButtonClick()
    {
        Debug.Log("Acertou");
    }
    public void PassarParaProximaPergunta()
    {
        SceneManager.LoadScene(proximaPergunta);
    }
    
    public void Btnerrado()
    {
        SceneManager.LoadScene(pergunta1);
    }
}
