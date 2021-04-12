using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class PlatformBehavior : MonoBehaviour
{

    protected Queue<Vector3> filterDataQueue = new Queue<Vector3>();
    public int filterLength = 3; //you could change it in inspector

    private float torque = 45f;

    private void Update()
    {
        RotatePlatform();
    }

    public Vector3 LowPassAccelerometer()
    {
        if (filterLength <= 0)
            return Input.acceleration;
        filterDataQueue.Enqueue(Input.acceleration);
        filterDataQueue.Dequeue();

        Vector3 vFiltered = Vector3.zero;
        foreach (Vector3 v in filterDataQueue)
            vFiltered += v;
        vFiltered /= filterLength;
        return vFiltered;
    }

    private void RotatePlatform()
    {
        /*
        float rotation = -LowPassAccelerometer().x;
        Debug.Log(LowPassAccelerometer().x);
        transform.rotation = Quaternion.Euler(0f, 0f, rotation * torque);
        */

        float torque = -Input.acceleration.x;
    }
}
