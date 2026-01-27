using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput input = null;
    private InputAction moveAction = null;
    private InputAction interactAction = null;
    [SerializeField] float moveSpeed = 8.0f;
    private Rigidbody2D rb = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        input = new PlayerInput();
        moveAction = input.Player.Move;
        interactAction = input.Player.Interact;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        input.Enable();
        moveAction.Enable();
        interactAction.Enable();
    }

    void OnDisable()
    {
        input.Disable();
        moveAction.Disable();
        interactAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement code
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 direction = moveInput.normalized;
        Debug.Log(moveInput);
        rb.linearVelocity = direction * moveSpeed;

    }
}
