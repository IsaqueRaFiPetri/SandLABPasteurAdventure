using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompleteAsLaunasToGame : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    [SerializeField] private Button CorrectButton;
    
    void Awake()
    {
        CorrectButton.onClick.AddListener(OnCorrectButtonClick);
    }
    
    void OnCorrectButtonClick()
    {
        Debug.Log("Acertou");
    }

    public void QuitSceneBTN()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
