using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 10f;
    private float turnSpeed = 0.5f;
    public Transform GroundCheck;
    public float Check = 0.2f;
    public float Gravcity = -9.8f;
    private bool isGround;
    public LayerMask layerMask;
    private Vector3 Velocity = Vector3.zero;
    public float JumpHeight = 3f;
    public float margin = 0.1f;
    private AudioSource source;
    private Animator animator;
    public bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movecontrol();
    }
    void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, margin);
    }
    private void Movecontrol()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertival = Input.GetAxis("Vertical");
        var move = transform.forward * speed * vertival * Time.deltaTime;
        controller.Move(move);
        transform.Rotate(Vector3.up * horizontal * turnSpeed);
        Velocity.y += Gravcity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
        if (IsGrounded() && Velocity.y < 0)
        {
            Velocity.y = 0;
        }
        if(IsGrounded()&& Input.GetButtonDown("Jump"))
        {
            Velocity.y += Mathf.Sqrt(JumpHeight * -2 * Gravcity);
        }
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S))
        {
            animator.SetBool("check", true);
        }
        else
        {
            animator.SetBool("check", false);
        }

    }
    
}

