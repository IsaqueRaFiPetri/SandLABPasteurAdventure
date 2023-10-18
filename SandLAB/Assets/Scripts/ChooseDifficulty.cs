using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseDifficulty : MonoBehaviour
{
    public Button FacilBTN;
    public Button DificilBTN;
    public Button CloseBTN;
    public string EasyScene;
    public string DifficultScene;
    public GameObject PainelDificuldades;


    public void FacilJogo()
    {
        SceneManager.LoadScene(EasyScene);
    }

    public void DificilJogo()
    {
        SceneManager.LoadScene(DifficultScene);
    }
    public void FecharPainel()
    {
        gameObject.SetActive(false);
        Debug.Log("Fechou");
    }
}