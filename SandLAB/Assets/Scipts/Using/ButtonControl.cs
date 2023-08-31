using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject text;
    
    public void ClearText()
    {
        text.GetComponent<InputField>().text = "";
    }
}
