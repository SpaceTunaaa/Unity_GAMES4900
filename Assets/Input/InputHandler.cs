using UnityEngine;

public class InputHandler : MonoBehaviour
{
    // old input handler
    private bool attackHeld;

    private void Update()
    {
        // detect press
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackHeld = true;
            Debug.Log("Attack Pressed");
        }

        // detect release
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            attackHeld = false;
            Debug.Log("Attack Released");
        }

        // detects holding
        if (Input.GetKey(KeyCode.Mouse0)) Debug.Log("Attack Held");

        // detect movement
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x -= 1f;
        if (Input.GetKey(KeyCode.D)) x += 1f;
        if (Input.GetKey(KeyCode.S)) y -= 1f;
        if (Input.GetKey(KeyCode.W)) y += 1f;

        Vector3 move = new Vector3(x, y, 0);
        // don't do anything if its not moving
        if (move != Vector3.zero)
        {
            Debug.Log($"Move {move}");
            // make the object in game move
            transform.position += move * 0.01f;
        }

    }
}
