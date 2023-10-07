using UnityEngine;
using UnityEngine.UI;

public class SaveNote : MonoBehaviour
{
    public string theText;
    public GameObject ourNote;
    public GameObject placeHolder;

    void Start()
    {
        theText = PlayerPrefs.GetString("NoteContent");
        placeHolder.GetComponent<InputField>().text = theText;
    }

    public void Save()
    {
        theText = ourNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContent", theText);
    }
}
