using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{

    private void Update()
    {
        CheckVoid();
    }

    private void CheckVoid()
    {
        // -10 is the limit
        if (transform.position.y <= -7) Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
