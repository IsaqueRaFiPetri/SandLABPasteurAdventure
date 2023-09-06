using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enterPlay : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    [SerializeField] private Button PlayButton; 

    private void Awake()
    {
        PlayButton.onClick.AddListener(OnButtonNotePadClick);
    }

    private void OnButtonNotePadClick()
    {
        Debug.Log("Play");
    }

    public void PlayBTN()
    {
        if (PlayButton)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
