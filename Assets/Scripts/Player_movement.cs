using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using TMPro;

public class Player_movement : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 movementInput;
    public Rigidbody2D rigidBody;
    public Animator anim;

    public int coinsCounter;
    public int health;

    public TextMeshProUGUI coinsCounterText, healthtext;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Horizontal", movementInput.y);
        anim.SetFloat("Vertical", movementInput.x);
        anim.SetFloat("Speed", movementInput.sqrMagnitude);

        coinsCounterText.text = coinsCounter.ToString();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coins"))
        {
            coinsCounter++;
            Destroy(collision.gameObject);
        }
    }
}
