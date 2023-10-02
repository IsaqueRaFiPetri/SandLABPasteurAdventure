using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseDifficulty : MonoBehaviour
{
    public Button FacilBTN;
    public Button DificilBTN;
    public string EasyScene; 
    public string DifficultScene; 

    public void FacilJogo()
    {
        SceneManager.LoadScene(EasyScene);
    }

    public void DificilJogo()
    {
        SceneManager.LoadScene(DifficultScene);
    }
}
