using UnityEngine;
using UnityEngine.SceneManagement;

public class enterPuzzels : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    public KeyCode keyToPress = KeyCode.Alpha0; // Change this to the key you want to use

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    /*[SerializeField] private Collider2D enterInPuzzles;

    private void Awake()
    {
        enterInPuzzles.assemblyOnCllick.AddListener(InColllidePuzzles());
    }

    private void InColllidePuzzles()
    {
        Debug.Log("Puzzles");
    }

    public void PuzzlesCollider()
    {
        Application.LoadLevel("");
    }*/
}
