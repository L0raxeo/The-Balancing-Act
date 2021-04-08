using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformBehavior : MonoBehaviour
{

    private float torque = 45f;

    private void Update()
    {
        RotatePlatform();
    }

    private void RotatePlatform()
    {
        float rotation = -Input.acceleration.x;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation * torque);
    }
}
