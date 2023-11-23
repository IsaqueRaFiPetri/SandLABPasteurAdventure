using UnityEngine;
using UnityEngine.UI;

public class NotePadButton : MonoBehaviour
{
    [SerializeField] private Button openNoteBTN;
    [SerializeField] private Button closeNoteBTN;
    public GameObject notePadPainel;
     
    private void Awake()
    {
        openNoteBTN.onClick.AddListener(OnOpenNotePadBTNClick);
        closeNoteBTN.onClick.AddListener(OnCloseNotePadBTNClick);
    }

    private void OnOpenNotePadBTNClick()
    {
        Debug.Log("Abriu");
    }
    private void OnCloseNotePadBTNClick()
    {
        Debug.Log("Fechar");
    }


    public void OpenNotePad()
    {
        notePadPainel.SetActive(true);
    }
    public void CloseNotePad()
    {
        notePadPainel.SetActive(false);
    }
}