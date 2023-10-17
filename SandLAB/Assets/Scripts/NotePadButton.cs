using UnityEngine;
using UnityEngine.UI;

public class NotePadButton : MonoBehaviour
{
    [SerializeField] private Button NoteButton;
    public GameObject NotePadPainel;
     
    private void Awake()
    {
        NoteButton.onClick.AddListener(OnButtonNotePadClick);
    }

    private void OnButtonNotePadClick()
    {
        Debug.Log("Bloco de Nota");
    }
    
    public void NoteSceneBTN()
    {
        gameObject.SetActive(true);
    }
}