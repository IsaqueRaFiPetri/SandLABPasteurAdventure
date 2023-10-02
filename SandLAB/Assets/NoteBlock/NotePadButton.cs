using UnityEngine;
using UnityEngine.UI;

public class NotePadButton : MonoBehaviour
{
    [SerializeField] private Button NoteButton;
     
    private void Awake()
    {
        NoteButton.onClick.AddListener(OnButtonNotePadClick);
    }

    private void OnButtonNotePadClick()
    {
        Debug.Log("Bloco");
    }
    
    public void NoteSceneBTN()
    {
        Application.LoadLevel("NoteScene");
    }
}