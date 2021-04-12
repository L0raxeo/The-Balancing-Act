using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformBehavior : MonoBehaviour
{

    public Rigidbody2D rb;

    private float torque = 45f;

    private void Update()
    {
        RotatePlatform();
    }

    private void RotatePlatform()
    {
        float torque = -Input.acceleration.x;

        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.z + torque * this.torque);
    }
}
