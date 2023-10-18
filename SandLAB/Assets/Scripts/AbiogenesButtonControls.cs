using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AbiogenesButtonControls : MonoBehaviour
{
    public string sceneNameToLoad;
    public Button sairBTN;
    public void sairPuzzle()
    {
        SceneManager.LoadScene(sceneNameToLoad);
        Debug.Log("saiu");
    }
}
