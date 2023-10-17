using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillBacteria : MonoBehaviour
{
    public GameObject bacterias;
    public string GameScene;

    private void OnMouseDown()
    {
        Debug.Log("I morreu");
        Destroy(gameObject);
        if(bacterias == null)
        {
            SceneManager.LoadScene(GameScene);
        }
    }
}
