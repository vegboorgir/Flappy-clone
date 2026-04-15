using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    [Header("Player Component refernece")]
    [SerializeField] Rigidbody2D rb;

    [Header("Player Setting")]
    [SerializeField] float jumpingPower;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        float bottomEdge = mainCamera.ViewportToWorldPoint(new Vector3(0,0,0)).y;
        float topEdge = mainCamera.ViewportToWorldPoint(new Vector3(0,1,0)).y;

        if(transform.position.y < bottomEdge || transform.position.y > topEdge)
        {
            Object.FindAnyObjectByType<GameManagerScript>().gameOverTrigger();
            
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpingPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Object.FindAnyObjectByType<GameManagerScript>().gameOverTrigger();
        }
    }
}
