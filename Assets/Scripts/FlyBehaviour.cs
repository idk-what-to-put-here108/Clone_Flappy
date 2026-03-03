using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehaviour : MonoBehaviour
{
    // Serialized Fields stating custom variables
    [SerializeField] private float _velocity = 1f;
    [SerializeField] private float _rotationspeed = 1f;

    //declaring the rigid Body 2d for player
    private Rigidbody2D rbody;

    //activating and getting the Rigid body 2D
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //constantly checks to see if the player is pressing LEFT MOUSE BUTTON with void Update command every frame
    //applies the verticle velocity from clicking the LEFT MOUSE BUTTON from the velocity variable listed above
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rbody.linearVelocity = Vector2.up * _velocity;
        }
    }

    //does that little rotation when moving up or diping down PURLY FOR THE FEEL OF FLAPPY BIRD
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rbody.linearVelocity.y * _rotationspeed);
    }
}
