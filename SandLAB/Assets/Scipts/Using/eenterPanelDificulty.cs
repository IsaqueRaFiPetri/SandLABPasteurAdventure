using UnityEngine;
using UnityEngine.SceneManagement;

public class eenterPanelDificulty : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use

    public void OnTriggerStay2D()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Panel.SetActive(true);
        }
    }
}
