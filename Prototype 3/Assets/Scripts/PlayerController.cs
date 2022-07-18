using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator playerAnim;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isGrounded = true;
    public bool gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !gameOver)
        {
            playerAnim.SetTrigger("Jump_trig");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
