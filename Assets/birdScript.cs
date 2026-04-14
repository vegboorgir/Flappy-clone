using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    [Header("Player Component refernece")]
    [SerializeField] Rigidbody2D rb;

    [Header("Player Setting")]
    [SerializeField] float jumpingPower;

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpingPower);
        }
    }
}
