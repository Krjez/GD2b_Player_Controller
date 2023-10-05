using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float jumpHeight = 7f;
    public float dashSpeed = 20f;
    public float crouchHeight = 0.5f;
    public LayerMask whatIsGround;
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.2f;

    public AudioClip jumpSound;
    public AudioClip dashSound;
    public AudioClip footStepSound;
    private Rigidbody2D body;
    private Animator anim;
    private AudioSource audioSource;
    private bool isGrounded;
    private bool canDoubleJump = false;
    private bool isDashing = false;
    private bool isCrouching = false;
    private bool isFacingRight = true;

    void Awake(){
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
