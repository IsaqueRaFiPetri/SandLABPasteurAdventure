using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButtonGame : MonoBehaviour
{
    [SerializeField] private Button QuitButton;

    /*private void Awake()
    {
        QuitButton.onClick.AddListener(OnButtonQuitClick);
    }*/

    private void OnButtonQuitClick()
    {
        Debug.Log("Sair");
    }

    public void QuitSceneBTN()
    {
        SceneManager.LoadScene("MenuScene");
    }
}