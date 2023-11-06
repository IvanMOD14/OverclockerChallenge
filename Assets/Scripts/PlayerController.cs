using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float Speed = 12f;
    public float SpeedShift = 20f;
    public float JumpForce = 3f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    
    bool shift = false;

    Vector3 velocity;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);//проверка на касание земли

        if (isGrounded && velocity.y < 0)//сброс скорости падени€
        {
            velocity.y = -2f;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical; //Ќужно дл€ того чтобы пон€ть куда смотрит игрок

        if (Input.GetButtonDown("Fire3") && isGrounded)
        {
            shift = true;
        }

        else if (Input.GetButtonUp("Fire3"))
        {
            shift = false;
        }

        if (shift == true)
        {
            controller.Move(movement * SpeedShift * Time.deltaTime);
        }
        else if (shift == false)
        {
            controller.Move(movement * Speed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpForce * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
