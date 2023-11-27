using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePosition : MonoBehaviour
{
    public float x;
    public float y;
    [SerializeField] private string sceneName;

    public void ReturnToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

}
