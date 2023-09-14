using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWhenDestroy : MonoBehaviour
{
    public string sceneNameToLoad;
    
    private void OnDestroy()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
    
}
