using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtonNote : MonoBehaviour
{
    [SerializeField] private Button QuitButton;
    public GameObject painelNotePad;

    private void Awake()
    {
        QuitButton.onClick.AddListener(OnButtonQuitClick);
    }
    private void OnButtonQuitClick()
    {
        Debug.Log("Sair");
    }


    public void QuitSceneBTN()
    {
        painelNotePad.SetActive(false);
    }

}
