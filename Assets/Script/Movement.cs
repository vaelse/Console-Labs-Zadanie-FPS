using UnityEngine;

public class Movement : MonoBehaviour
{
    FPSControls input;
    CharacterController controller;
    Transform cameraTransform;

    public float MovementSpeed;
    public float jumpHeight;

    private readonly float currentMovementSpeed = 5f;
    private readonly float gravity = 9f;
    private float Falling;
    private Vector2 inputVector = Vector2.zero;
    private Vector3 moveDir;

    private void Awake()
    {
        input = new FPSControls();
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        InputManager();
    }

    public void InputManager()
    {
        input.Player.Moving.performed += ctx => inputVector = ctx.ReadValue<Vector2>();
    }

    public void Moving()
    {
        if (input.Player.Sprint.ReadValue<float>() != 0 && controller.isGrounded)
        {
            MovementSpeed = 8f;
        }
        else
        {
            MovementSpeed = currentMovementSpeed;
        }

        var moveDirection = cameraTransform.forward * inputVector.y + cameraTransform.right * inputVector.x;
        moveDir.x = moveDirection.x * MovementSpeed;
        moveDir.z = moveDirection.z * MovementSpeed;
        Jumping();
        controller.Move(moveDir * Time.deltaTime);
    }
  
    private void Update()
    {
        Moving();
    }

    public void Jumping()
    {
        if (controller.isGrounded && input.Player.Jump.triggered)
        {
            Falling = jumpHeight;
        }

        Falling -= gravity * Time.deltaTime;
        moveDir.y = Falling;
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
}