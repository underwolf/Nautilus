using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2d controller;

    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump=false;
    public bool playerMove=true;
    bool canDoubleJump;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = true;   
    }

    
    // Update is called once per frame
    void Update()
    {
        if (playerMove)
        {
            horizontalMove = (Input.GetAxisRaw("Horizontal") * speed);

            if (Input.GetButtonDown("Jump"))
            {
                if (controller.isGrounded())
                {
                    jump = true;
                    canDoubleJump = true;
                }
                else if (canDoubleJump)
                {
                    controller.Jump();
                    canDoubleJump = false;
                }

            }
            if (Input.GetButtonUp("Jump") && controller.GetVelocity() > 0)
            {
                controller.ChangeJumpvelocity();
            }
            {

            }
        }

    }

    public void setPlayerMove(bool CanMove)
    {
        playerMove = CanMove;
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
