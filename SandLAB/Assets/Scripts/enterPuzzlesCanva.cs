using UnityEngine;

public class enterPuzzlesCanva : MonoBehaviour
{
    public GameObject painel; // The name of the scene you want to load
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use

    public void OnTriggerStay2D()
    {
        if (Input.GetKey(KeyCode.E))
        {
            painel.SetActive(true);
        }
    }
}
