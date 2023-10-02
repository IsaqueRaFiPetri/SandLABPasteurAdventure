using UnityEngine;
using UnityEngine.UI;

public class eenterPanelDificulty : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use
    [SerializeField] private Button ClosePainelBTN;

    public void OnTriggerStay2D()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Panel.SetActive(true);
        }
    }
    public void ClosePainel()
    {
        Panel.SetActive(false);
    }
}
