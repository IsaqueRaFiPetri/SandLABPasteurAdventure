using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    [SerializeField] private Rigidbody2D rb2D;
    private Vector2 playerDirection;

    #region Moviment

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        playerDirection = new Vector2(horizontal, vertical);
    }
    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
    }

    #endregion Moviment

}