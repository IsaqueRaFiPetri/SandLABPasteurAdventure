using UnityEngine;

public class KillBacteria : MonoBehaviour
{
    public GameObject Bacterias;

    private void OnMouseDown()
    {
        Debug.Log("I morreu");
        Destroy(gameObject);
    }
}
