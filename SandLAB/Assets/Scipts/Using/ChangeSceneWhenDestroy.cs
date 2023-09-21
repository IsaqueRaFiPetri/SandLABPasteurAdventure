using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWhenDestroy : MonoBehaviour
{
    public string sceneNameToLoad;
    public GameObject Bacterias;
    
    public void OnDestroy()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
    
}
