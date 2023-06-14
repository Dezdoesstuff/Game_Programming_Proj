using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class Player_movement : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 movementInput;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("knight_Forward");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("knight_Backward");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("knight_Left");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("knight_Right");
        }
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
