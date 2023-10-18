using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peyeranim : MonoBehaviour
{
        public Animator anim;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);
    }
}
