using UnityEngine;
using UnityEngine.SceneManagement;

public class enterPuzzels : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use

    private void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    
}
