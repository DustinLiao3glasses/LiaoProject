using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    [Header("數值調整")]
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpAmount = 10;
    [SerializeField]
    private float gravityScale = 10;
    [SerializeField]
    private float fallingGravityScale = 40;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb2d.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
