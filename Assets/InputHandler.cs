using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private PlayerControls controls;
    public Vector2 MoveInput { get; private set; }

    private void Awake()
    {
        controls = new PlayerControls();

        // Subscribing to the Move action
        controls.Player.Move.performed += ctx => MoveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => MoveInput = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}