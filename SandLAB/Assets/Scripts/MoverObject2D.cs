using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//requer um BoxCollider
[RequireComponent(typeof(Rigidbody2D))]
public class MoverObject2D : MonoBehaviour //funciona apenas com cameras ortograficas
{
    Vector3 startingPosition;
    Vector3 finalPosition;
    Vector3 directionVector;
    Rigidbody2D _rigidbody2D;
    bool isDragging;
    float distance;
    
    [HideInInspector]
    public bool isConected;
    [Range(1, 15)]
    public float movVelocity = 10;
    [Space(10)]
    public Transform conector;
    [Range(0.1f, 2.0f)]
    public float minimunDistanceFromConector = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 1;
    }

    void OnMouseDown()
    {
        startingPosition = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody2D.gravityScale = 0;
        isDragging = true;
        isConected = false;
    }
    void OnMouseDrag()
    {
        finalPosition = startingPosition + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        directionVector = finalPosition - transform.root.position;
        _rigidbody2D.velocity = directionVector * movVelocity;
    }
    void OnMouseUp()
    {
        _rigidbody2D.gravityScale = 1;
        isDragging = false;
    }

    void FixedUpdate()
    {
        if(!isDragging &&  !isConected)
        {
            distance = Vector2.Distance(transform.root.position, conector.position);
            if(distance < minimunDistanceFromConector)
            {
                _rigidbody2D.gravityScale = 0;
                _rigidbody2D.velocity = Vector2.zero;
                transform.root.position = Vector2.MoveTowards(transform.root.position, conector.position, 0.02f);
            }
            if (distance < 0.01)
            {
                isConected = true;
                transform.root.position = conector .position;
            }
        }
    }
}

//video de referencia - https://www.youtube.com/watch?v=EohhGbRgNds
