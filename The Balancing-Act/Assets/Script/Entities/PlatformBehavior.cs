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
<<<<<<< HEAD
        /*
        float rotation = -LowPassAccelerometer().x;
        Debug.Log(LowPassAccelerometer().x);
=======
        float rotation = -Input.acceleration.x;
>>>>>>> parent of 8a87ed8 (Testing Physics 2D Mechanics)
        transform.rotation = Quaternion.Euler(0f, 0f, rotation * torque);
        */

        float torque = -Input.acceleration.x;
    }
}
