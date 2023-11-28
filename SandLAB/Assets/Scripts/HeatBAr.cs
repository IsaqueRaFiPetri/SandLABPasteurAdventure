using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatBar : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -1f;
    public float strenght = 5f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strenght;
        }
        /*if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase)
        }*/
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
