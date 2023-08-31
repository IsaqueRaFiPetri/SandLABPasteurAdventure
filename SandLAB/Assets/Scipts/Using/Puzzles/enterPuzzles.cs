using UnityEngine;
using UnityEngine.SceneManagement;

public class enterPuzzles : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use

    public void OnTriggerStay2D()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
