using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    public Custom_Input_Action_Map input; // reference the script we generated
    private bool attackHeld = false;

    private void Start()
    {
    }

    private void OnEnable()
    {
        // initialize input
        input = new Custom_Input_Action_Map();

        input.Player.Enable();

        // attatch the functions
        input.Player.attack.performed += AttackPressed;
        input.Player.attack.started += _ => attackHeld = true;
        input.Player.attack.canceled += AttackReleased;
    }

    private void OnDisable()
    {
        input.Player.attack.performed -= AttackPressed;
        input.Player.attack.canceled -= AttackReleased;

        input.Player.Disable(); // making sure that disabled object does not take inputs
    }

    private void AttackPressed(InputAction.CallbackContext _) => Debug.Log("Attack Pressed");
    private void AttackReleased(InputAction.CallbackContext _)
    {
        attackHeld = false;
        Debug.Log("Attack Released");
    }

    private void Update()
    {
        if (attackHeld) Debug.Log("Attack Held");

        Vector2 move = input.Player.Move.ReadValue<Vector2>();
        if (move != Vector2.zero)
        {
            transform.position += new Vector3(move.x, move.y, 0) * 0.01f;
        }
    }
}
