using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    public float Speed = 10f;
    public float RotateSpeed = 2f;
    public float Gravity = -9.8f;
    private Vector3 Velocity = Vector3.zero;
    public float CheckRadius = 0.2f;
    public LayerMask layerMask;

    public float JumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        if (Velocity.y < 0)
        {
            Velocity.y = 0;
        }

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);

        Velocity.y += Gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, horizontal * RotateSpeed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PickUp")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
