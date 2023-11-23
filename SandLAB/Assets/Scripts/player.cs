using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    public float speed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.deltaTime;
    }

}

//video de referencia: https://www.youtube.com/watch?v=P8GF_clL1Y0