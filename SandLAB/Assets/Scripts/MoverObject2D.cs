using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//requer um BoxCollider
[RequireComponent(typeof(Rigidbody2D))]
public class MoverObject2D : MonoBehaviour //funciona apenas com cameras ortograficas
{
    Vector3 posicaoinicial;
    Vector3 posicaoDestino;
    Vector3 vetorDirecao;
    Rigidbody2D _rigidbody2D;
    bool estaArrastando;
    float distancia;

    [HideInInspector]
    public bool estaConectado;
    [Range(1, 15)]
    public float velocidadeDeMovimento = 10;
    [Space(10)]
    public Transform conector;
    [Range(0.1f, 2.0f)]
    public float distanciaMinimaConector = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 1;
    }

    private void OnMouseDown()
    {
        posicaoinicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody2D.gravityScale = 0;
        estaArrastando = true;
        estaConectado = false;
    }
    private void OnMouseDrag()
    {
        posicaoDestino = posicaoinicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vetorDirecao = posicaoDestino - transform.root.position;
        _rigidbody2D.velocity = vetorDirecao * velocidadeDeMovimento;
    }
    private void OnMouseUp()
    {
        _rigidbody2D.gravityScale = 1;
        estaArrastando = false;
    }   
}

//video de referencia - https://www.youtube.com/watch?v=EohhGbRgNds
