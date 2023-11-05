using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerRed : MonoBehaviour
{
    [SerializeField]
    [Range(0,10)]
    public float speed = 2.5f;
    [SerializeField]
    [Range(0,20)]
    public float jumpSpeed = 8f;
    private float height = 0f;
    private float direction = 0f;
    Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator playerAnimation;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        height = Input.GetAxis("Vertical");
        direction = Input.GetAxis("Horizontal");
        Vector3 localScale = transform.localScale;

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            if (localScale.x < 0f) {
                localScale.x *= -1;
                transform.localScale = localScale;
            }
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            if (localScale.x > 0f) {
                localScale.x *= -1;
                transform.localScale = localScale;
            }
            
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
        playerAnimation.SetBool("OnGround", isTouchingGround);
        playerAnimation.SetFloat("Speed", Mathf.Abs(player.velocity.x));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("Enemy") ) {
            Debug.Log("Collision Trigger");
            SceneManager.LoadScene(5);
        }
    }

}
